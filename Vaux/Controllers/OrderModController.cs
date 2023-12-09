using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Vaux.DTO.Out;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories;
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
        public IActionResult Get(int pageNum = 1, int pageSize = -1, string? search = null)
        {
            var query = _orderRepo.Query();
            query = query.OrderByDescending(e => e.Id);
            if (search != null)
            {
                query = query.Where(e => e.User.Name.Contains(search));
            }
            return Ok(_orderRepo.WrapListResult<OrderOutDTO>(query, (pageNum - 1) * pageSize, pageSize));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_orderRepo.Get<OrderOutDTO>(e => e.Id == id));
        }
    }
}
