using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;
using Vaux.VNPayIntegration;

namespace Vaux.Controllers
{
    [Route("api/Order")]
    [ApiController]
    [Authorize]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepo _orderRepo;
        private readonly IItemRepo _itemRepo;
        private readonly IVnPayServiceRepo _vnPayService;

        public OrderController(IOrderRepo orderRepo, IItemRepo itemRepo, IVnPayServiceRepo vnPayService)
        {
            _orderRepo = orderRepo;
            _itemRepo = itemRepo;
            _vnPayService = vnPayService;
        }

        [HttpGet]
        public IActionResult Get(bool completed)
        {
            return Ok(_orderRepo.GetAll<OrderOutDTO>(e => e.UserId.ToString() == User.Identity!.Name && e.Shipment.All(s => s.Status == ShipmentStatus.SHIPPED && completed)));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_orderRepo.Get<OrderOutDTO>(e => e.Id == id && e.UserId.ToString() == User.Identity!.Name));
        }

        [HttpPost]
        public IActionResult Create([FromBody] int[] itemIds)
        {
            var items = _itemRepo.GetAll<Item>(e => itemIds.Contains(e.Id) && e.HighestBid!.UserId.ToString() == User.Identity!.Name);
            if (items.TotalRecords == 0)
            {
                return BadRequest("Đã có lỗi xảy ra!");
            }
            
            return Ok(_orderRepo.Create<OrderOutDTO>(itemIds));
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult CancelOrder(int id)
        {
            var items = _orderRepo.GetAll<Item>(e => e.Id == id && e.UserId.ToString() == User.Identity!.Name && e.Status == OrderStatus.UNPAID);
            if (items.TotalRecords == 0)
            {
                return BadRequest("Đã có lỗi xảy ra!");
            }

            return Ok(_orderRepo.Delete<OrderOutDTO>(e => e.Id == id));
        }


        [HttpPost]
        [Route("{id}/Pay")]
        public IActionResult CreatePayment(int id, OrderPaymentDTO address)
        {
            var order = _orderRepo.Get<Order>(e => e.Id == id);
            if (order == null)
            {
                return BadRequest("Đơn thanh toán không tồn tại!");
            }

            _orderRepo.Update<Order, OrderPaymentDTO>(e => e.Id == id, address);

            PaymentInformation paymentInformation = new PaymentInformation();
            paymentInformation.Name = $"VXBO{order.Id}";
            paymentInformation.OrderDescription = $"Payment for order VXBO{order.Id}";
            paymentInformation.OrderType = "200000";
            paymentInformation.Amount = order.TotalCost;

            return Ok(_vnPayService.CreatePaymentUrl(paymentInformation, HttpContext));
        }

        [HttpPatch]
        [Route("{id}/ConfirmPayment")]
        public IActionResult ConfirmPayment(int id)
        {
            var order = _orderRepo.Get<Order>(e => e.Id == id);
            if (order == null)
            {
                return BadRequest("Đơn thanh toán không tồn tại!");
            }

            var payment = _vnPayService.PaymentExecute(Request.Query);

            if (!payment.Success)
            {
                return StatusCode(402, "Thanh toán thất bại!");
            }

            return Ok(_orderRepo.ConfirmPaid<OrderOutDTO>(e => e.Id == id));
        }
    }
}
