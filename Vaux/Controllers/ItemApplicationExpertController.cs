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
    [Route("api/Expert/ItemApplication")]
    [ApiController]
    [Authorize(Roles = $"{nameof(RoleId.EXPERT)}")]
    public class ItemApplicationExpertController : ControllerBase
    {
        private IItemRepo _itemRepo;
        private IPhotoRepo _photoRepo;
        private IBaseRepo<Notification> _notificationRepo;

        public ItemApplicationExpertController(IItemRepo itemRepo, IPhotoRepo photoRepo, IBaseRepo<Notification> notificationRepo)
        {
            _itemRepo = itemRepo;
            _photoRepo = photoRepo;
            _notificationRepo = notificationRepo;
        }

        [HttpGet]
        [Route("{id}")]
        [Authorize(Roles = $"{nameof(RoleId.EXPERT)},{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        public IActionResult Get(int id)
        {
            var i = _itemRepo.Get<ItemDTO>(e => e.Id == id);
            if (i == null)
            {
                return BadRequest();
            }

            return Ok(i);
        }

        [HttpGet]
        [Authorize(Roles = $"{nameof(RoleId.EXPERT)},{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        public IActionResult GetAll(int pageNum = 1, int pageSize = 30, string? search = null)
        {
            return Ok(_itemRepo.GetAll<ItemDTO>(e => search.IsNullOrEmpty() ? true : (e.Name.Contains(search) || e.Category.Name.Contains(search)), e => e.Id, (pageNum - 1) * pageSize, pageSize));
        }

        [HttpGet]
        [Route("{id}/Images/{imageId}")]
        [Authorize(Roles = $"{nameof(RoleId.EXPERT)},{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        public IActionResult GetImages(int id, int imageId)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i?.Images?.FirstOrDefault(e => e.Id == imageId) == null)
            {
                return BadRequest();
            }

            return File(_photoRepo.Get(id).ToArray(), "image/jpeg");
        }

        [HttpPut]
        [Route("{id}/Assign")]
        [Authorize(Roles = $"{nameof(RoleId.EXPERT)},{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
        public IActionResult Assign(int id)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null || i.Status != ItemStatus.EXAMINATION_PENDING || i.ExpertId != null)
            {
                return BadRequest();
            }
            i.ExpertId = int.Parse(User.Identity.Name);

            _notificationRepo.Create<Notification, Notification>(new Notification()
            {
                UserId = i.SellerId,
                Content = $"Đăng ký sản phẩm \"{i.Name}\" đã được tiếp nhận bởi chuyên gia"
            });

            return Ok(_itemRepo.Update<ItemDTO, Item>(e => e.Id == id, i));
        }

        [HttpPut]
        [Route("{id}/Unassign")]
        public IActionResult Unassign(int id)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null || i.Status != ItemStatus.EXAMINATION_PENDING || i.ExpertId?.ToString() != User.Identity.Name)
            {
                return BadRequest();
            }
            i.ExpertId = null;

            _notificationRepo.Create<Notification, Notification>(new Notification()
            {
                UserId = i.SellerId,
                Content = $"Đăng ký sản phẩm \"{i.Name}\" đang chờ xử lý"
            });

            return Ok(_itemRepo.Update<ItemDTO, Item>(e => e.Id == id, i));
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Edit(int id, ItemPropertiesDTO item)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null || i.Status != ItemStatus.EXAMINATION_PENDING || i.ExpertId?.ToString() != User.Identity.Name) 
            {
                return BadRequest();
            }

            _notificationRepo.Create<Notification, Notification>(new Notification()
            {
                UserId = i.SellerId,
                Content = $"Đăng ký sản phẩm \"{i.Name}\" đã được cập nhật bởi chuyên gia"
            });

            return Ok(_itemRepo.Update<ItemDTO, ItemPropertiesDTO>(e => e.Id == id, item));
        }

        [HttpPatch]
        [Route("{id}/Accept")]
        public IActionResult Accept(int id, [FromBody] string reason)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null || i.Status != ItemStatus.EXAMINATION_PENDING || i.ExpertId?.ToString() != User.Identity.Name)
            {
                return BadRequest();
            }

            i.Status = ItemStatus.AUCTION_PENDING;

            _notificationRepo.Create<Notification, Notification>(new Notification()
            {
                UserId = i.SellerId,
                Content = $"Đăng ký sản phẩm \"{i.Name}\" đã được phê duyệt"
            });

            return Ok(_itemRepo.Update<ItemDTO, Item>(e => e.Id == i.Id, i, reason));
        }

        [HttpPatch]
        [Route("{id}/Reject")]
        public IActionResult Reject(int id, [FromBody] string reason)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null || i.Status != ItemStatus.EXAMINATION_PENDING || i.ExpertId?.ToString() != User.Identity.Name)
            {
                return BadRequest();
            }

            i.Status = ItemStatus.REJECTED;

            _notificationRepo.Create<Notification, Notification>(new Notification()
            {
                UserId = i.SellerId,
                Content = $"Đăng ký sản phẩm \"{i.Name}\" đã bị từ chối"
            });

            return Ok(_itemRepo.Update<ItemDTO, Item>(e => e.Id == i.Id, i, reason));
        }
    }
}
