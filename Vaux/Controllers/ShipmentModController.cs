using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vaux.DTO.Out;
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
        public IActionResult Get(int pageNum = 1, int pageSize = -1, ShipmentStatus? status = null, string? search = null)
        {
            var query = _shipmentRepo.Query();
            query = query.OrderByDescending(e => e.Id);
            if (status != null)
            {
                query = query.Where(e => e.Status == status);
            }
            if (search != null)
            {
                query = query.Where(e => e.Id.ToString() == search || e.Items.Any(i => i.Name.Contains(search)));
            }
            return Ok(_shipmentRepo.WrapListResult<ShipmentOutDTO>(query, (pageNum - 1) * pageSize, pageSize));
        }

        [HttpPatch]
        [Route("{id}/ChangeStatus")]
        public IActionResult ChangeStatus(int id, [FromBody] ShipmentStatus status)
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
