using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vaux.DbContext;
using Vaux.DTO;
using Vaux.DTO.Out;
using Vaux.Models.Enums;

namespace Vaux.Controllers
{
    [Route("api/Mod/Dashboard")]
    [ApiController]
    [Authorize(Roles = $"{nameof(RoleId.ADMIN)},{nameof(RoleId.MODERATOR)}")]
    public class DashboardController : ControllerBase
    {
        private VxDbc _vxDbc;

        public DashboardController(VxDbc vxDbc)
        {
            _vxDbc = vxDbc;
        }

        [HttpGet]
        [Route("Accounts")]
        public IActionResult Accounts(DateTime from, DateTime to)
        {
            Dictionary<string, object> res = new();

            var query = _vxDbc.Users.AsQueryable();

            res.Add("TotalUsers", query.Count());
            res.Add("BannedUsers", query.IgnoreQueryFilters().Where(e => e.Deleted != null).Count());
            res.Add("NewUsers", query.Where(e => e.Created.Date >= from.Date && e.Created.Date <= to.Date).Count());
            res.Add("Sellers", query.Where(e => e.RoleId == (int)RoleId.SELLER).Count());
            res.Add("Experts", query.Where(e => e.RoleId == (int)RoleId.EXPERT).Count());

            return Ok(res);
        }

        [HttpGet]
        [Route("SoldItems")]
        public IActionResult SoldItems(DateTime from, DateTime to)
        {
            Dictionary<string, object> res = new();

            var query = _vxDbc.Items.Where(e => e.Created >= from.Date && e.Created <= to.Date);

            res.Add("Result",
                query.Where(e => e.Status == ItemStatus.PAID)
                    .GroupBy(e => e.WonDate!.Value.Month)
                    .Select(e => new { Month = e.Key, Count = e.Count() })
                    .ToArray());

            return Ok(res);
        }

        [HttpGet]
        [Route("UnsoldItems")]
        public IActionResult UnsoldItems(DateTime from, DateTime to)
        {
            Dictionary<string, object> res = new();

            var query = _vxDbc.StatusChanges.Where(e => e.Created >= from.Date && e.Created <= to.Date);

            res.Add("Result",
                query.Where(e => e.StatusTo == ItemStatus.RE_AUCTION_PENDING.ToString())
                    .GroupBy(e => e.Created.Month)
                    .Select(e => new { Month = e.Key, Count = e.Count() })
                    .ToArray());

            return Ok(res);
        }

        [HttpGet]
        [Route("UnpaidItems")]
        public IActionResult UnpaidItems(DateTime from, DateTime to)
        {
            Dictionary<string, object> res = new();

            var query = _vxDbc.StatusChanges.Where(e => e.Created >= from.Date && e.Created <= to.Date);

            res.Add("Result",
                query.Where(e => e.StatusFrom == ItemStatus.PAYMENT_PENDING.ToString() && e.StatusTo == ItemStatus.RE_AUCTION_PENDING.ToString())
                    .GroupBy(e => e.Created.Month)
                    .Select(e => new { Month = e.Key, Count = e.Count() })
                    .ToArray());

            return Ok(res);
        }

        [HttpGet]
        [Route("ExpertContribution")]
        public IActionResult ExpertContribution(DateTime from, DateTime to, int? id = null)
        {
            Dictionary<string, object> res = new();
            var query = _vxDbc.StatusChanges.Where(e => e.Created >= from.Date && e.Created <= to.Date);

            query = query.Where(e => e.StatusFrom == ItemStatus.EXAMINATION_PENDING.ToString() && e.StatusTo == ItemStatus.AUCTION_PENDING.ToString());

            if (id != null)
            {
                query = query.Where(e => e.StatusChangedById == id);
            }

            res.Add("Result", query.GroupBy(e => e.StatusChangedById).Select(e => new { Id = e.Key, Count = e.Count(), Name = _vxDbc.Users.First(u => u.Id == e.Key).Name }).ToArray());

            return Ok(res);
        }

        [HttpGet]
        [Route("AuctionReport")]
        public IActionResult AuctionReport(DateTime from, DateTime to)
        {
            Dictionary<string, object> res = new();
            var auctions = _vxDbc.AuctionSessions.Where(e => e.StartDate >= from && e.EndDate <= to && e.Status == AuctionSessionStatus.FINISHED).ToList();
            foreach (var auction in auctions)
            {
                var report = auction.Report;
                res.Add(auction.Id.ToString(), new 
                {
                    auction = new AuctionSessionMinimalDTO()
                    {
                        Id = auction.Id,
                        EndDate = auction.EndDate,
                        StartDate = auction.StartDate,
                        Status = auction.Status
                    },
                    report = report
                });
            }

            return Ok(res);
        }
    }
}
