using Microsoft.Extensions.Logging;
using Quartz;
using System.Threading.Tasks;
using Vaux.DbContext;
using Vaux.Models.Enums;
using Vaux.Models;

namespace Vaux.CronJobs
{
    [DisallowConcurrentExecution]
    public class EndAuctionJob : IJob
    {
        private VxDbc _vxDbc;
        private readonly ILogger<EndAuctionJob> _logger;

        public EndAuctionJob(VxDbc vxDbc, ILogger<EndAuctionJob> logger)
        {
            _vxDbc = vxDbc;
            _logger = logger;
        }

        public Task Execute(IJobExecutionContext context)
        {
            var eligibleAuctions = _vxDbc.AuctionSessions.Where(e => e.StartDate.Date == DateTime.Today).ToList();
            foreach (var auc in eligibleAuctions)
            {
                auc.Status = AuctionSessionStatus.FINISHED;

                foreach (var item in auc.Items)
                {
                    var highestBid = item.Bids?.LastOrDefault();
                    if (highestBid?.Amount >= item.ReservePrice)
                    {
                        item.Status = ItemStatus.PAYMENT_IN_PROGRESS;
                        item.StatusChanges.Add(new StatusChange()
                        {
                            StatusFrom = ItemStatus.AUCTION_IN_PROGRESS.ToString(),
                            StatusTo = ItemStatus.PAYMENT_IN_PROGRESS.ToString(),
                            StatusChangedById = 1,
                            StatusChangeReason = $"Item won by user {highestBid.UserId}"
                        });

                        item.Seller.Notifications.Add(new Notification()
                        {
                            Content = $"Sản phẩm {item.Name} đã được đấu giá thành công",
                            UserId = item.SellerId
                        });

                        highestBid.User.Notifications.Add(new Notification()
                        {
                            Content = $"Bạn đã thắng được sản phẩm {item.Name}",
                            UserId = highestBid.UserId
                        });
                    }
                    else
                    {
                        item.Status = ItemStatus.RE_AUCTION_PENDING;
                        item.StatusChanges.Add(new StatusChange()
                        {
                            StatusFrom = ItemStatus.AUCTION_IN_PROGRESS.ToString(),
                            StatusTo = ItemStatus.RE_AUCTION_PENDING.ToString(),
                            StatusChangedById = 1,
                            StatusChangeReason = $"Item auction failed"
                        });

                        item.Seller.Notifications.Add(new Notification()
                        {
                            Content = $"Sản phẩm {item.Name} đã không được đấu giá thành công",
                            UserId = item.SellerId
                        });
                    }
                }
            }

            _vxDbc.SaveChanges();

            _logger.LogInformation("Auction Ended");

            return Task.CompletedTask;
        }
    }
}
