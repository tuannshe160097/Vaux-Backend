﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("api/Mod/Shipment")]
    [ApiController]
    public class ShipmentController : ControllerBase
    {
        IBaseRepo<Shipment> _shipmentRepo;

        public ShipmentController(IBaseRepo<Shipment> shipemntRepo)
        {
            _shipmentRepo = shipemntRepo;
        }

        [HttpPatch]
        [Route("{id}/ChangeStatus")]
        public IActionResult ChangeStatus(int id, ShipmentStatus status)
        {
            var s = _shipmentRepo.Get<Shipment>(e => e.Id == id);
            if (s == null)
            {
                return BadRequest();
            }

            s.Status = status;
            return Ok(_shipmentRepo.Update<ShipmentOutDTO, Shipment>(e => e.Id == id, s));
        }
    }
}
