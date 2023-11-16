using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("api/Mod/Item")]
    [ApiController]
    [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
    public class ItemModController : ControllerBase
    {
        private IItemRepo _itemRepo;
        private IPhotoRepo _photoRepo;
        private IBaseRepo<Notification> _notificationRepo;

        public ItemModController(IItemRepo itemRepo, IPhotoRepo photoRepo, IBaseRepo<Notification> notificationRepo)
        {
            _itemRepo = itemRepo;
            _photoRepo = photoRepo;
            _notificationRepo = notificationRepo;
        }

        [HttpGet]
        [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        public IActionResult GetAll(int pageNum = 1, int pageSize = -1, string? search = null, int? category = null, int? status = null)
        {
            var query = _itemRepo.Query();
            query = query.OrderByDescending(e => e.ExpertId != null);
            if (search != null)
            {
                query = query.Where(e => e.Name.Contains(search));
            }
            if (status != null)
            {
                query = query.Where(e => (int)e.Status == status);
            }
            if (category != null)
            {
                query = query.Where(e => e.CategoryId == category);
            }
            return Ok(_itemRepo.WrapListResult<ItemDTO>(query, (pageNum - 1) * pageSize, pageSize));
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Edit(int id, ItemApplicationDTO item)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null)
            {
                return BadRequest();
            }

            _notificationRepo.Create<Notification, Notification>(new Notification()
            {
                UserId = i.SellerId,
                Content = $"Đăng ký sản phẩm \"{i.Name}\" đã được cập nhật bởi chuyên gia"
            });

            return Ok(_itemRepo.Update<ItemDTO, ItemApplicationDTO>(e => e.Id == id, item));
        }

        [HttpPatch]
        [Route("{id}/ChangeStatus")]
        public IActionResult ChangeStatus(int id, StatusChangeDTO statusChange)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null)
            {
                return BadRequest();
            }

            i.Status = statusChange.Status;

            return Ok(_itemRepo.Update<ItemDTO, Item>(e => e.Id == i.Id, i));
        }

        [HttpPost]
        [Route("{id}/Images")]
        public IActionResult AddImage(int id, [FromForm] ImageCollectionDTO images)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null)
            {
                return BadRequest();
            }

            var res = _itemRepo.AddImages<Image>(e => e.Id == id, images.Images);

            return Ok(res);
        }

        [HttpDelete]
        [Route("{id}/Images")]
        public IActionResult RemoveImages(int id, int[] imageIds)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null)
            {
                return BadRequest();
            }

            var res = _itemRepo.RemoveImages<ItemDTO>(e => e.Id == id, imageIds);

            return Ok(res);
        }


        [HttpPut]
        [Route("{id}/Unassign")]
        public IActionResult Unassign(int id)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null)
            {
                return BadRequest();
            }
            i.ExpertId = int.Parse(User.Identity.Name);

            _notificationRepo.Create<Notification, Notification>(new Notification()
            {
                UserId = i.SellerId,
                Content = $"Đăng ký sản phẩm \"{i.Name}\" đang chờ xử lý"
            });

            return Ok(_itemRepo.Update<ItemDTO, Item>(e => e.Id == id, i));
        }
    }
}
