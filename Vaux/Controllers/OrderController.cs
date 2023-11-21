using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vaux.DTO;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("api/Order")]
    [ApiController]
    [Authorize]
    public class OrderController : ControllerBase
    {
        private IOrderRepo _orderRepo;

        public OrderController(IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }

        [HttpGet]
        public IActionResult Get(bool completed)
        {
            return Ok(_orderRepo.GetAll<OrderOutDTO>(e => e.UserId.ToString() == User.Identity!.Name && e.Shipment.All(s => s.Status == ShipmentStatus.SHIPPED && completed)));
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            return Ok(_orderRepo.Get<OrderOutDTO>(e => e.Id == id && e.UserId.ToString() == User.Identity!.Name));
        }

        [HttpGet]
        public IActionResult CalculateShip([FromQuery] int[] itemIds)
        {
            return Ok(_orderRepo.CalculateShip(itemIds));
        }
    }
}
