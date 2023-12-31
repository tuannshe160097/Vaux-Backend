﻿using Microsoft.AspNetCore.Authorization;
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
    [Route("api/Mod/Item")]
    [ApiController]
    [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
    public class ItemModController : ControllerBase
    {
        private readonly IItemRepo _itemRepo;
        private readonly INotificationRepo _notificationRepo;
        private readonly IConfiguration _configuration;

        public ItemModController(IItemRepo itemRepo, INotificationRepo notificationRepo, IConfiguration configuration)
        {
            _itemRepo = itemRepo;
            _notificationRepo = notificationRepo;
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult GetAll(int pageNum = 1, int pageSize = -1, string? search = null, int? category = null, int? status = null)
        {
            var query = _itemRepo.Query();
            query = query.OrderByDescending(e => e.Id);
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
            return Ok(_itemRepo.WrapListResult<ItemOutDTO>(query, (pageNum - 1) * pageSize, pageSize));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var i = _itemRepo.Get<ItemOutDTO>(e => e.Id == id);
            if (i == null)
            {
                return BadRequest("Sản phẩm không tồn tại!");
            }

            return Ok(i);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Edit(int id, ItemApplicationDTO item)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null)
            {
                return BadRequest("Sản phẩm không tồn tại!");
            }

            _notificationRepo.Create<Notification>(e => e.Id == i.SellerId, $"Đăng ký sản phẩm \"{i.Name}\" đã được cập nhật bởi quản trị viên", $"{_configuration["JWT:Audience"]}/seller/detail?itemId={i.Id}");

            return Ok(_itemRepo.Update<ItemOutDTO, ItemApplicationDTO>(e => e.Id == id, item));
        }

        [HttpPatch]
        [Route("{id}/ChangeStatus")]
        public IActionResult ChangeStatus(int id, StatusChangeDTO statusChange)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null)
            {
                return BadRequest("Sản phẩm không tồn tại!");
            }

            i.Status = statusChange.Status;

            return Ok(_itemRepo.Update<ItemOutDTO, Item>(e => e.Id == i.Id, i, statusChange.StatusChangeReason));
        }

        [HttpPost]
        [Route("{id}/Images")]
        public IActionResult AddImage(int id, [FromForm] ImageCollectionDTO images)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null)
            {
                return BadRequest("Sản phẩm không tồn tại!");
            }

            var res = _itemRepo.AddImages<ItemOutDTO>(e => e.Id == id, images.Images);

            return Ok(res);
        }

        [HttpDelete]
        [Route("{id}/Images")]
        public IActionResult RemoveImages(int id, int[] imageIds)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null)
            {
                return BadRequest("Sản phẩm không tồn tại!");
            }

            var res = _itemRepo.RemoveImages<ItemOutDTO>(e => e.Id == id, imageIds);

            return Ok(res);
        }


        [HttpPut]
        [Route("{id}/Unassign")]
        public IActionResult Unassign(int id)
        {
            var i = _itemRepo.Get<Item>(e => e.Id == id);
            if (i == null)
            {
                return BadRequest("Sản phẩm không tồn tại!");
            }

            i.ExpertId = null;

            _notificationRepo.Create<Notification>(e => e.Id == i.SellerId, $"Đăng ký sản phẩm \"{i.Name}\" đang chờ xử lý", $"{_configuration["JWT:Audience"]}/seller/detail?itemId={i.Id}");

            return Ok(_itemRepo.Update<ItemOutDTO, Item>(e => e.Id == id, i));
        }
    }
}
