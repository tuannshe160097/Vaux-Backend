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

        public ItemApplicationController(IItemRepo itemRepo, IPhotoRepo photoRepo)
        {
            _itemRepo = itemRepo;
            _photoRepo = photoRepo;
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
            return Ok(_itemRepo.Get<ItemDTO>(e => e.Id.ToString() == User.Identity.Name));
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
            if (i?.SellerId.ToString() != User.Identity.Name || i?.Images?.FirstOrDefault(e => e.Id == imageId) == null)
            {
                return BadRequest();
            }

            return File(_photoRepo.Get(id).ToArray(), "image/jpeg");
        }

        [HttpPost]
        [Route("{id}/Images")]
        public IActionResult AddImages(int id, IFormFileCollection images)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null || i.SellerId.ToString() != User.Identity.Name)
            {
                return BadRequest();
            }

            var res = _itemRepo.AddImages<Image>(e => e.Id == id, images);

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

            return Ok(_itemRepo.Delete<ItemDTO>(e => e.Id == id));
        }
    }
}
