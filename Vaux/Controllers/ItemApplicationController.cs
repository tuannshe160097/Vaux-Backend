using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using Vaux.DTO;
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
        private IItemRepo _itemRepo;
        private IPhotoRepo _photoRepo;
        private IBaseRepo<Notification> _notificationRepo;

        public ItemApplicationController(IItemRepo itemRepo, IPhotoRepo photoRepo, IBaseRepo<Notification> notificationRepo)
        {
            _itemRepo = itemRepo;
            _photoRepo = photoRepo;
            _notificationRepo = notificationRepo;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var i = _itemRepo.Get<ItemDTO>(e => e.Id == id);
            if (i == null || i.SellerId.ToString() != User.Identity.Name)
            {
                return BadRequest();
            }

            return Ok(i);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_itemRepo.GetAll<ItemDTO>(e => e.SellerId.ToString() == User.Identity.Name));
        }

        [HttpPost]
        public IActionResult Create(ItemApplicationDTO item)
        {
            var res = _itemRepo.Create<ItemDTO, ItemApplicationDTO>(item, int.Parse(User.Identity.Name));
            return Ok(res);
        }

        [HttpGet]
        [Route("{id}/Images/{imageId}")]
        public IActionResult GetImages(int id, int imageId)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i?.SellerId.ToString() != User.Identity.Name || (i?.Images?.FirstOrDefault(e => e.Id == imageId) == null && i?.ThumbnailId != imageId))
            {
                return BadRequest();
            }

            return File(_photoRepo.Get(id).ToArray(), "image/jpeg");
        }

        [HttpPatch]
        [Route("{id}/Thumbnail")]
        public IActionResult Thumbnail(int id, [FromForm] IFormFile thumbnail)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null || i.SellerId.ToString() != User.Identity.Name)
            {
                return BadRequest();
            }

            if (i.ExpertId != null)
            {
                _notificationRepo.Create<Notification, Notification>(new Notification()
                {
                    UserId = (int)i.ExpertId,
                    Content = $"Đăng ký sản phẩm \"{i.Name}\" đã được thêm ảnh"
                });
            }

            return Ok(_itemRepo.EditThumbnail<ItemDTO>(e => e.Id == id, thumbnail));
        }


        [HttpPost]
        [Route("{id}/Images")]
        public IActionResult AddImages(int id, [FromForm] ImageCollectionDTO images)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null || i.SellerId.ToString() != User.Identity.Name)
            {
                return BadRequest();
            }

            if (i.ExpertId != null)
            {
                _notificationRepo.Create<Notification, Notification>(new Notification()
                {
                    UserId = (int)i.ExpertId,
                    Content = $"Đăng ký sản phẩm \"{i.Name}\" đã được thêm ảnh"
                });
            }

            var res = _itemRepo.AddImages<ItemDTO>(e => e.Id == id, images.Images);

            return Ok(res);
        }

        [HttpDelete]
        [Route("{id}/Images")]
        public IActionResult RemoveImages(int id, int[] imageIds)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null || i.SellerId.ToString() != User.Identity.Name)
            {
                return BadRequest();
            }

            var res = _itemRepo.RemoveImages<ItemDTO>(e => e.Id == id, imageIds);

            return Ok(res);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Edit(int id, ItemApplicationDTO item)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null || i.SellerId.ToString() != User.Identity.Name)
            {
                return BadRequest();
            }

            if (i.ExpertId != null)
            {
                _notificationRepo.Create<Notification, Notification>(new Notification()
                {
                    UserId = (int)i.ExpertId,
                    Content = $"Đăng ký sản phẩm \"{i.Name}\" đã được cập nhật"
                });
            }

            return Ok(_itemRepo.Update<ItemDTO, ItemApplicationDTO>(e => e.Id == id, item));
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null || i.SellerId.ToString() != User.Identity.Name)
            {
                return BadRequest();
            }

            if (i.ExpertId != null)
            {
                _notificationRepo.Create<Notification, Notification>(new Notification()
                {
                    UserId = (int)i.ExpertId,
                    Content = $"Đăng ký sản phẩm \"{i.Name}\" đã bị xóa"
                });
            }

            return Ok(_itemRepo.Delete<ItemDTO>(e => e.Id == id));
        }
    }
}
