using Microsoft.AspNetCore.Authorization;
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
                return BadRequest();
            }

            return Ok(auc);
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_auctionRepo.GetAll<AuctionSessionMinimalDTO>());
        }

        [HttpPost]
        public IActionResult Create(AuctionSessionUploadDTO auction)
        {
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
                return BadRequest();
            }

            auction.StartDate = auction.StartDate.Date.AddHours(7);
            auction.EndDate = auction.EndDate.Date.AddHours(19);

            return Ok(_auctionRepo.Update<AuctionSessionIFullDTO, AuctionSessionUploadDTO>(e => e.Id == id, auction, auction.ItemIds));
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            var auc = _auctionRepo.Get<AuctionSession>(e => e.Id == id);
            if (auc == null)
            {
                return BadRequest();
            }

            return Ok(_auctionRepo.Delete<AuctionSessionIFullDTO>(e => e.Id == id));
        }
    }
}
