using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Security.Cryptography;
using Vaux.DTO.In;
using Vaux.DTO.Out;
using Vaux.Hubs;
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
        private readonly IHubContext<BidHub> _bidHub;

        public AuctionSessionController(IAuctionSessionRepo auctionRepo, IHubContext<BidHub> hub)
        {
            _auctionRepo = auctionRepo;
            _bidHub = hub;
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
        public IActionResult Get(int pageNum = 1, int pageSize = -1, DateTime? from = null, DateTime? to = null, AuctionSessionStatus? status = null)
        {
            var query = _auctionRepo.Query();
            query = query.OrderByDescending(e => e.Id);
            if (from != null)
            {
                query = query.Where(e => e.StartDate > from || e.EndDate > from);
            }
            if (to != null)
            {
                query = query.Where(e => e.StartDate < to || e.EndDate < to);
            }
            if (status != null)
            {
                query = query.Where(e => e.Status == status);
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
            var auc = _auctionRepo.Get<AuctionSession>(e => e.Id == id);
            if (auc == null)
            {
                return BadRequest("Phiên đấu giá không tồn tại!");
            }
            if (auc.Status != AuctionSessionStatus.PENDING)
            {
                return BadRequest("Không thể cập nhật phiên đấu giá đã bắt đầu!");
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
                return BadRequest("Không thể xóa phiên đang hoạt động!");
            }

            return Ok(_auctionRepo.Delete<AuctionSessionIFullDTO>(e => e.Id == id));
        }

        [HttpPatch]
        [Route("{id}/ForceStart")]
        public IActionResult ForceStart(int id)
        {
            if (_auctionRepo.Get<AuctionSession>(e =>  e.Id == id && e.Status == AuctionSessionStatus.PENDING) == null)
            {
                return BadRequest("Phiên đấu giá không tồn tại");
            }

            _auctionRepo.ForceStartSession(id);

            return Ok("Bắt đầu phiên đấu giá thành công");
        }

        [HttpPatch]
        [Route("{id}/ForceEnd")]
        public IActionResult ForceEnd(int id)
        {
            if (_auctionRepo.Get<AuctionSession>(e => e.Id == id && e.Status == AuctionSessionStatus.ONGOING) == null)
            {
                return BadRequest("Phiên đấu giá không tồn tại");
            }

            _auctionRepo.ForceEndSession(id);
            _bidHub.Clients.All.SendAsync("AuctionEnd");

            return Ok("Kết thúc phiên đấu giá thành công");
        }
    }
}
