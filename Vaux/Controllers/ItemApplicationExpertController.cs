using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Vaux.DTO;
using Vaux.DTO.Out;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("api/Expert/ItemApplication")]
    [ApiController]
    public class ItemApplicationExpertController : ControllerBase
    {
        private readonly IItemRepo _itemRepo;
        private readonly INotificationRepo _notificationRepo;
        private readonly IConfiguration _configuration;

        public ItemApplicationExpertController(IItemRepo itemRepo, INotificationRepo notificationRepo, IConfiguration configuration)
        {
            _itemRepo = itemRepo;
            _notificationRepo = notificationRepo;
            _configuration = configuration;
        }

        [HttpGet]
        [Route("{id}")]
        [Authorize(Roles = $"{nameof(RoleId.EXPERT)},{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        public IActionResult Get(int id)
        {
            var i = _itemRepo.Get<ItemOutDTO>(e => e.Id == id && e.Status == ItemStatus.EXAMINATION_PENDING);
            if (i == null)
            {
                return BadRequest("Sản phẩm không tồn tại!");
            }

            return Ok(i);
        }

        [HttpGet]
        [Authorize(Roles = $"{nameof(RoleId.EXPERT)},{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        public IActionResult GetAll(int pageNum = 1, int pageSize = -1, string? search = null, int? category = null, bool? selfAssigned = null)
        {
            var query = _itemRepo.Query().Where(e => e.Status == ItemStatus.EXAMINATION_PENDING);
            query = query.OrderByDescending(e => e.ExpertId != null ? 1 : 0).ThenByDescending(e => e.Id);
            if (search != null)
            {
                query = query.Where(e => e.Name.Contains(search));
            }
            if (category != null)
            {
                query = query.Where(e => e.CategoryId == category);
            }
            if (selfAssigned != null)
            {
                query = selfAssigned == true ? query.Where(e => e.ExpertId.ToString() == User.Identity!.Name) : query.Where(e => e.ExpertId.ToString() != User.Identity!.Name);
            }
            return Ok(_itemRepo.WrapListResult<ItemOutDTO>(query, (pageNum - 1) * pageSize, pageSize));
        }

        [HttpPut]
        [Route("{id}/Assign")]
        [Authorize(Roles = $"{nameof(RoleId.EXPERT)},{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        public IActionResult Assign(int id)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null || i.Status != ItemStatus.EXAMINATION_PENDING || i.ExpertId != null)
            {
                return BadRequest("Sản phẩm không tồn tại!");
            }

            i.ExpertId = int.Parse(User.Identity!.Name!);

            _notificationRepo.Create<Notification>(e => e.Id == i.SellerId, $"Đăng ký sản phẩm \"{i.Name}\" đã được tiếp nhận bởi chuyên gia", $"{_configuration["JWT:Audience"]}/seller/detail?itemId={i.Id}");

            return Ok(_itemRepo.Update<ItemOutDTO, Item>(e => e.Id == id, i));
        }

        [HttpPut]
        [Route("{id}/Unassign")]
        [Authorize(Roles = $"{nameof(RoleId.EXPERT)}")]
        public IActionResult Unassign(int id)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null || i.Status != ItemStatus.EXAMINATION_PENDING || i.ExpertId?.ToString() != User.Identity!.Name)
            {
                return BadRequest("Sản phẩm không tồn tại!");
            }
            i.ExpertId = null;

            _notificationRepo.Create<Notification>(e => e.Id == i.SellerId, $"Đăng ký sản phẩm \"{i.Name}\" đang chờ xử lý", $"{_configuration["JWT:Audience"]}/seller/detail?itemId={i.Id}");

            return Ok(_itemRepo.Update<ItemOutDTO, Item>(e => e.Id == id, i));
        }

        [HttpPut]
        [Route("{id}")]
        [Authorize(Roles = $"{nameof(RoleId.EXPERT)}")]
        public IActionResult Edit(int id, ItemPropertiesDTO item)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null || i.Status != ItemStatus.EXAMINATION_PENDING || i.ExpertId?.ToString() != User.Identity!.Name) 
            {
                return BadRequest("Sản phẩm không tồn tại!");
            }

            _notificationRepo.Create<Notification>(e => e.Id == i.SellerId, $"Đăng ký sản phẩm \"{i.Name}\" đã được cập nhật bởi chuyên gia", $"{_configuration["JWT:Audience"]}/seller/detail?itemId={i.Id}");

            return Ok(_itemRepo.Update<ItemOutDTO, ItemPropertiesDTO>(e => e.Id == id, item));
        }

        [HttpPatch]
        [Route("{id}/Accept")]
        [Authorize(Roles = $"{nameof(RoleId.EXPERT)}")]
        public IActionResult Accept(int id, [FromBody] string reason)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null || i.Status != ItemStatus.EXAMINATION_PENDING || i.ExpertId?.ToString() != User.Identity!.Name)
            {
                return BadRequest("Sản phẩm không tồn tại!");
            }

            i.Status = ItemStatus.AUCTION_PENDING;

            _notificationRepo.Create<Notification>(e => e.Id == i.SellerId, $"Đăng ký sản phẩm \"{i.Name}\" đã được phê duyệt", $"{_configuration["JWT:Audience"]}/seller/detail?itemId={i.Id}");

            return Ok(_itemRepo.Update<ItemOutDTO, Item>(e => e.Id == i.Id, i, reason));
        }

        [HttpPatch]
        [Route("{id}/Reject")]
        [Authorize(Roles = $"{nameof(RoleId.EXPERT)}")]
        public IActionResult Reject(int id, [FromBody] string reason)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null || i.Status != ItemStatus.EXAMINATION_PENDING || i.ExpertId?.ToString() != User.Identity!.Name)
            {
                return BadRequest("Sản phẩm không tồn tại!");
            }

            i.Status = ItemStatus.REJECTED;

            _notificationRepo.Create<Notification>(e => e.Id == i.SellerId, $"Đăng ký sản phẩm \"{i.Name}\" đã bị từ chối", $"{_configuration["JWT:Audience"]}/seller/detail?itemId={i.Id}");

            return Ok(_itemRepo.Update<ItemOutDTO, Item>(e => e.Id == i.Id, i, reason));
        }
    }
}
