using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories;
using Vaux.Repositories.Interface;
using Vaux.VNPayIntegration;

namespace Vaux.Controllers
{
    [Route("api/SellerPayment")]
    [ApiController]
    [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
    public class SellerPaymentController : ControllerBase
    {
        private readonly ISellerPaymentRepo _sellerPaymentRepo;
        private readonly IVnPayServiceRepo _vnPayService;

        public SellerPaymentController(ISellerPaymentRepo sellerPaymentRepo, IVnPayServiceRepo vnPayService)
        {
            _sellerPaymentRepo = sellerPaymentRepo;
            _vnPayService = vnPayService;
        }

        [HttpGet]
        public IActionResult Get(int pageNum = 1, int pageSize = -1, SellerPaymentStatus? status = null)
        {
            var query = _sellerPaymentRepo.Query();
            if (status != null)
            {
                query = query.Where(e => e.Status == status);
            }

            return Ok(_sellerPaymentRepo.WrapListResult<SellerApplicationOutDTO>(query, (pageNum - 1) * pageSize, pageSize));
        }

        [HttpGet]
        [Route("{id}/CreatePayment")]
        public IActionResult CreatePayment(int id)
        {
            var payment = _sellerPaymentRepo.Get<SellerPayment>(e => e.Id == id);
            if (payment == null)
            {
                return BadRequest();
            }

            PaymentInformation paymentInformation = new PaymentInformation();
            paymentInformation.Name = $"VXSP{payment.Id}";
            paymentInformation.OrderDescription = $"Payment for SellerPayment VXSP{payment.Id}";
            paymentInformation.OrderType = "200000";
            paymentInformation.Amount = payment.Amount;

            return Ok(_vnPayService.CreatePaymentUrl(paymentInformation, HttpContext));
        }

        [HttpPatch]
        [Route("{id}/ConfirmPayment")]
        public IActionResult ConfirmPayment(int id)
        {
            var p = _sellerPaymentRepo.Get<SellerPayment>(e => e.Id == id);
            if (p == null)
            {
                return BadRequest();
            }

            var payment = _vnPayService.PaymentExecute(Request.Query);

            if (!payment.Success)
            {
                return StatusCode(402);
            }

            return Ok(_sellerPaymentRepo.ConfirmPaid<OrderOutDTO>(e => e.Id == id));
        }
    }
}
