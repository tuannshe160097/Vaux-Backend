using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories;
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
        public IActionResult Get(int pageNum = 1, int pageSize = -1, ShipmentStatus? status = null, string? search = null)
        {
            var query = _shipmentRepo.Query().Where(e => e.Order.UserId.ToString() == User.Identity!.Name);
            query = query.OrderByDescending(e => e.Id);
            if (status != null)
            {
                query = query.Where(e => e.Status == status);
            }
            if (search != null)
            {
                query = query.Where(e => e.Items.Any(i => i.Name.Contains(search)));
            }
            return Ok(_shipmentRepo.WrapListResult<ShipmentOutDTO>(query, (pageNum - 1) * pageSize, pageSize));
        }
    }
}
