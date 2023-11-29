﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vaux.DTO;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.Controllers
{
    [Route("api/Mod/Auction")]
    [ApiController]
    [Authorize(Roles = $"{nameof(RoleId.MODERATOR)},{nameof(RoleId.ADMIN)}")]
    public class AuctionSessionController : ControllerBase
    {
        private IAuctionSessionRepo _auctionRepo;

        public AuctionSessionController(IAuctionSessionRepo auctionRepo)
        {
            _auctionRepo = auctionRepo;
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var auc = _auctionRepo.Get<AuctionSessionIFullDTO>(e => e.Id == id);
            if (auc == null)
            {
                return BadRequest("Phiên đấu giá không tồn tại!");
            }

            return Ok(auc);
        }

        [HttpGet]
        public IActionResult Get(int pageNum = 1, int pageSize = -1, DateTime? from = null, DateTime? to = null)
        {
            var query = _auctionRepo.Query();
            query.OrderByDescending(e => e.Id);
            if (from != null)
            {
                query = query.Where(e => e.StartDate > from || e.EndDate > from);
            }
            if (to != null)
            {
                query = query.Where(e => e.StartDate < to || e.EndDate < to);
            }
            return Ok(_auctionRepo.WrapListResult<AuctionSessionMinimalDTO>(query, (pageNum - 1) * pageSize, pageSize));
        }

        [HttpPost]
        public IActionResult Create(AuctionSessionUploadDTO auction)
        {
            if (auction.StartDate.Date <= DateTime.Today) 
            {
                return BadRequest("Ngày bắt đầu phiên phải ở sau ngày hiện tại!");
            }
            if(auction.StartDate.Date >= auction.EndDate.Date)
            {
                return BadRequest("Ngày kết thúc phiên phải ở sau ngày bắt đầu!");
            }

            auction.StartDate = auction.StartDate.Date.AddHours(7);
            auction.EndDate = auction.EndDate.Date.AddHours(19);
            return Ok(_auctionRepo.Create<AuctionSessionIFullDTO, AuctionSessionUploadDTO>(auction, auction.ItemIds));
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update(int id, AuctionSessionUploadDTO auction)
        {
            var auc = _auctionRepo.Get<AuctionSession>(e => e.Id == id && e.Status == AuctionSessionStatus.PENDING);
            if (auc == null)
            {
                return BadRequest("Phiên đấu giá không tồn tại!");
            }

            if (auction.StartDate.Date <= DateTime.Today)
            {
                return BadRequest("Ngày bắt đầu phiên phải ở sau ngày hiện tại!");
            }
            if (auction.StartDate.Date >= auction.EndDate.Date)
            {
                return BadRequest("Ngày kết thúc phiên phải ở sau ngày bắt đầu!");
            }

            auction.StartDate = auction.StartDate.Date.AddHours(7);
            auction.EndDate = auction.EndDate.Date.AddHours(19);

            return Ok(_auctionRepo.Update<AuctionSessionIFullDTO, AuctionSessionUploadDTO>(e => e.Id == id, auction, auction.ItemIds));
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var auc = _auctionRepo.Get<AuctionSession>(e => e.Id == id && e.Status == AuctionSessionStatus.PENDING);
            if (auc == null)
            {
                return BadRequest("Phiên đấu giá không tồn tại!");
            }

            return Ok(_auctionRepo.Delete<AuctionSessionIFullDTO>(e => e.Id == id));
        }
    }
}
