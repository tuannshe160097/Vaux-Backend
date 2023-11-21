using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vaux.DTO;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("api/[controller]")]
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
    }
}
