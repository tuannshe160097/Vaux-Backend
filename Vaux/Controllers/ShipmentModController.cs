using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("api/Mod/Shipment")]
    [ApiController]
    [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
    public class ShipmentModController : ControllerBase
    {
        private readonly IBaseRepo<Shipment> _shipmentRepo;

        public ShipmentModController(IBaseRepo<Shipment> shipemntRepo)
        {
            _shipmentRepo = shipemntRepo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_shipmentRepo.GetAll<ShipmentOutDTO>());
        }

        [HttpPatch]
        [Route("{id}/ChangeStatus")]
        public IActionResult ChangeStatus(int id, ShipmentStatus status)
        {
            var s = _shipmentRepo.Get<Shipment>(e => e.Id == id);
            if (s == null)
            {
                return BadRequest("Kiện hàng không tồn tại!");
            }

            s.Status = status;
            return Ok(_shipmentRepo.Update<ShipmentOutDTO, Shipment>(e => e.Id == id, s));
        }
    }
}
