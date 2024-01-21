using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using Vaux.DTO;
using Vaux.DTO.Out;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("api/Seller/ItemApplication")]
    [ApiController]
    [Authorize(Roles = $"{nameof(RoleId.SELLER)}")]
    public class ItemApplicationController : ControllerBase
    {
        private readonly IItemRepo _itemRepo;
        private readonly INotificationRepo _notificationRepo;
        private readonly IConfiguration _configuration;

        public ItemApplicationController(IItemRepo itemRepo, INotificationRepo notificationRepo, IConfiguration configuration)
        {
            _itemRepo = itemRepo;
            _notificationRepo = notificationRepo;
            _configuration = configuration;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var i = _itemRepo.Get<ItemOutDTO>(e => e.Id == id);
            if (i == null )
            {
                return BadRequest("Sản phẩm không tồn tại!");
            }
            if (i.SellerId.ToString() != User.Identity!.Name)
            {
                return BadRequest("Không có quyền thực hiện hành động này!");
            }

            return Ok(i);
        }

        [HttpGet]
        public IActionResult GetAll(int pageNum = 1, int pageSize = -1, string? search = null, int? category = null, ItemStatus? status = null)
        {
            var query = _itemRepo.Query().Where(e => e.SellerId.ToString() == User.Identity!.Name);
            query = query.OrderByDescending(e => e.Id);
            if (search != null)
            {
                query = query.Where(e => e.Name.Contains(search));
            }
            if (category != null)
            {
                query = query.Where(e => e.CategoryId == category);
            }
            if (status != null)
            {
                query = query.Where(e => e.Status == status);
            }
            return Ok(_itemRepo.WrapListResult<ItemOutDTO>(query, (pageNum - 1) * pageSize, pageSize));
        }

        [HttpPost]
        public IActionResult Create(ItemApplicationDTO item)
        {
            var res = _itemRepo.Create<ItemOutDTO, ItemApplicationDTO>(item, int.Parse(User.Identity!.Name!));
            return Ok(res);
        }

        [HttpPatch]
        [Route("{id}/Thumbnail")]
        public IActionResult Thumbnail(int id, [FromForm] ImageDTO thumbnail)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id && e.Status == ItemStatus.EXAMINATION_PENDING);
            if (i == null || i.SellerId.ToString() != User.Identity!.Name)
            {
                return BadRequest("Tài khoản không hợp lệ!");
            }

            if (i.ExpertId != null)
            {
                _notificationRepo.Create<Notification>(e => e.Id == i.ExpertId, $"Đăng ký sản phẩm \"{i.Name}\" đã được thêm ảnh", $"{_configuration["JWT:Audience"]}/expert/items/view?itemId={i.Id}");
            }

            return Ok(_itemRepo.EditThumbnail<ItemOutDTO>(e => e.Id == id, thumbnail.Image));
        }


        [HttpPost]
        [Route("{id}/Images")]
        public IActionResult AddImages(int id, [FromForm] ImageCollectionDTO images)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id && e.Status == ItemStatus.EXAMINATION_PENDING);
            if (i == null || i.SellerId.ToString() != User.Identity!.Name)
            {
                return BadRequest("Tài khoản không hợp lệ!");
            }

            if (i.ExpertId != null)
            {
                _notificationRepo.Create<Notification>(e => e.Id == i.ExpertId, $"Đăng ký sản phẩm \"{i.Name}\" đã được thêm ảnh", $"{_configuration["JWT:Audience"]}/expert/items/view?itemId={i.Id}");
            }

            var res = _itemRepo.AddImages<ItemOutDTO>(e => e.Id == id, images.Images);

            return Ok(res);
        }

        [HttpDelete]
        [Route("{id}/Images")]
        public IActionResult RemoveImages(int id, int[] imageIds)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id && e.Status == ItemStatus.EXAMINATION_PENDING);
            if (i == null || i.SellerId.ToString() != User.Identity!.Name)
            {
                return BadRequest("Tài khoản không hợp lệ!");
            }

            var res = _itemRepo.RemoveImages<ItemOutDTO>(e => e.Id == id, imageIds);

            return Ok(res);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Edit(int id, ItemApplicationDTO item)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id && e.Status == ItemStatus.EXAMINATION_PENDING);
            if (i == null || i.SellerId.ToString() != User.Identity!.Name)
            {
                return BadRequest("Tài khoản không hợp lệ!");
            }

            if (i.ExpertId != null)
            {
                _notificationRepo.Create<Notification>(e => e.Id == i.ExpertId, $"Đăng ký sản phẩm \"{i.Name}\" đã được cập nhật", $"{_configuration["JWT:Audience"]}/expert/items/view?itemId={i.Id}");
            }

            return Ok(_itemRepo.Update<ItemOutDTO, ItemApplicationDTO>(e => e.Id == id, item));
        }

        [HttpPatch]
        [Route("{id}/ReAuction")]
        public IActionResult ReAuction(int id)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id && e.Status == ItemStatus.RE_AUCTION_PENDING);
            if (i == null || i.SellerId.ToString() != User.Identity!.Name)
            {
                return BadRequest("Tài khoản không hợp lệ!");
            }

            i.Status = ItemStatus.AUCTION_PENDING;
            return Ok(_itemRepo.Update<ItemOutDTO, Item>(e => e.Id == id, i));
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id && e.Status == ItemStatus.EXAMINATION_PENDING);
            if (i == null || i.SellerId.ToString() != User.Identity!.Name)
            {
                return BadRequest("Tài khoản không hợp lệ!");
            }

            if (i.ExpertId != null)
            {
                _notificationRepo.Create<Notification>(e => e.Id == i.ExpertId, $"Đăng ký sản phẩm \"{i.Name}\" đã bị xóa", $"{_configuration["JWT:Audience"]}/expert/items/view?itemId={i.Id}");
            }

            return Ok(_itemRepo.Delete<ItemOutDTO>(e => e.Id == id));
        }
    }
}
