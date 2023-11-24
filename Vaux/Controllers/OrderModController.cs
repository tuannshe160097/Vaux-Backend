using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("api/Mod/Order")]
    [ApiController]
    [Authorize(Roles = $"{nameof(RoleId.ADMIN)},{nameof(RoleId.MODERATOR)}")]
    public class OrderModController : ControllerBase
    {
        private IOrderRepo _orderRepo;

        public OrderModController(IOrderRepo orderRepo, IBaseRepo<Shipment> shipmentRepo)
        {
            _orderRepo = orderRepo;
        }

        [HttpGet]
        public IActionResult Get(bool completed)
        {
            return Ok(_orderRepo.GetAll<OrderOutDTO>(e => e.Shipment.All(s => s.Status == ShipmentStatus.SHIPPED && completed)));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_orderRepo.Get<OrderOutDTO>(e => e.Id == id));
        }
    }
}
