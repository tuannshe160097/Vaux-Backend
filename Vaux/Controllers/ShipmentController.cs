using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("api/Shipment")]
    [ApiController]
    [Authorize]
    public class ShipmentController : ControllerBase
    {
        private readonly IBaseRepo<Shipment> _shipmentRepo;

        public ShipmentController(IBaseRepo<Shipment> shipmentRepo)
        {
            _shipmentRepo = shipmentRepo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_shipmentRepo.GetAll<ShipmentOutDTO>(e => e.Order.UserId.ToString() == User.Identity!.Name));
        }
    }
}
