﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("api/Mod/ItemApplication")]
    [ApiController]
    [Authorize($"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
    public class ItemApplicationModController : ControllerBase
    {
        private IItemRepo _itemRepo;
        private IPhotoRepo _photoRepo;

        public ItemApplicationModController(IItemRepo itemRepo, IPhotoRepo photoRepo)
        {
            _itemRepo = itemRepo;
            _photoRepo = photoRepo;
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult ModEdit(int id, ItemApplicationDTO item)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null)
            {
                return BadRequest();
            }

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
        public IActionResult AddImages(int id, IFormFileCollection images)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null)
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
            if (i == null)
            {
                return BadRequest();
            }

            var res = _itemRepo.RemoveImages<ItemDTO>(e => e.Id == id, imageIds);

            return Ok(res);
        }
    }
}
