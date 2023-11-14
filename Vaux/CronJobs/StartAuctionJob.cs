using Microsoft.Extensions.Logging;
using Quartz;
using System.Threading.Tasks;
using Vaux.DbContext;
using Vaux.Models;
using Vaux.Models.Enums;

namespace Vaux.CronJobs
{
    [DisallowConcurrentExecution]
    public class StartAuctionJob : IJob
    {
        private VxDbc _vxDbc;
        private readonly ILogger<StartAuctionJob> _logger;

        public StartAuctionJob(VxDbc vxDbc, ILogger<StartAuctionJob> logger)
        {
            _vxDbc = vxDbc;
            _logger = logger;
        }

        public Task Execute(IJobExecutionContext context)
        {
            var eligibleAuctions = _vxDbc.AuctionSessions.Where(e => e.StartDate.Date == DateTime.Today).ToList();
            foreach (var auc in eligibleAuctions)
            {
                auc.Status = AuctionSessionStatus.ONGOING;
                
                foreach (var item in auc.Items)
                {
                    item.Status = ItemStatus.AUCTION_IN_PROGRESS;
                    item.StatusChanges.Add(new StatusChange()
                    {
                        StatusFrom = ItemStatus.AUCTION_PENDING.ToString(),
                        StatusTo = ItemStatus.AUCTION_IN_PROGRESS.ToString(),
                        StatusChangedById = 1,
                        StatusChangeReason = "Start auction"
                    });

                    item.Seller.Notifications.Add(new Notification()
                    {
                        Content = $"Sản phẩm {item.Name} đã bắt đầu được đấu giá",
                        UserId = item.SellerId
                    });
                }
            }

            _vxDbc.SaveChanges();

            _logger.LogInformation("Auction Started");

            return Task.CompletedTask;
        }
    }
}
