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
    [Route("api/ItemPayment")]
    [ApiController]
    [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
    public class ItemPaymentController : ControllerBase
    {
        private readonly IItemPaymentRepo _itemPaymentRepo;

        public ItemPaymentController(IItemPaymentRepo itemPaymentRepo)
        {
            _itemPaymentRepo = itemPaymentRepo;
        }

        [HttpGet]
        public IActionResult Get(int pageNum = 1, int pageSize = -1, ItemPaymentStatus? status = null)
        {
            var query = _itemPaymentRepo.Query();
            if (status != null)
            {
                query = query.Where(e => e.Status == status);
            }

            return Ok(_itemPaymentRepo.WrapListResult<SellerApplicationOutDTO>(query, (pageNum - 1) * pageSize, pageSize));
        }
    }
}
