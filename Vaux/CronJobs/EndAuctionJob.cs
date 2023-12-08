using Microsoft.Extensions.Logging;
using Quartz;
using System.Threading.Tasks;
using Vaux.DbContext;
using Vaux.Models.Enums;
using Vaux.Models;
using Vaux.Repositories.Interface;

namespace Vaux.CronJobs
{
    [DisallowConcurrentExecution]
    public class EndAuctionJob : IJob
    {
        private readonly VxDbc _vxDbc;
        private readonly ILogger<EndAuctionJob> _logger;
        private readonly INotificationRepo _notificationRepo;

        public EndAuctionJob(VxDbc vxDbc, ILogger<EndAuctionJob> logger, INotificationRepo notificationRepo)
        {
            _vxDbc = vxDbc;
            _logger = logger;
            _notificationRepo = notificationRepo;
        }

        public Task Execute(IJobExecutionContext context)
        {
            var eligibleAuctions = _vxDbc.AuctionSessions.Where(e => e.EndDate.Date == DateTime.Today).ToList();
            foreach (var auc in eligibleAuctions)
            {
                AuctionSessionReport report = new AuctionSessionReport()
                {
                    AuctionedItems = 0,
                    SoldItems = 0,
                    UnauctionedItems = 0,
                    UnpaidItems = 0,
                    ActiveItems = 0,
                    ActiveBids = 0,
                    ActiveBidders = 0,
                    ActiveSellers = 0,
                    TotalRevenue = 0,
                };
                auc.Report = report;
                auc.Status = AuctionSessionStatus.FINISHED;

                report.ActiveBidders = _vxDbc.Bids.Where(e => e.AuctionSessionId == auc.Id).GroupBy(e => e.UserId).Count();
                report.ActiveSellers = auc.Items!.GroupBy(e => e.SellerId).Count();

                foreach (var item in auc.Items!)
                {
                    report.ActiveItems++;
                    report.ActiveBids += item.Bids!.Count;
                    var highestBid = item.HighestBid;
                    if (highestBid?.Amount >= item.ReservePrice)
                    {
                        report.AuctionedItems++;
                        item.Status = ItemStatus.PAYMENT_PENDING;
                        item.OngoingSession = null;
                        item.StatusChanges!.Add(new StatusChange()
                        {
                            StatusFrom = ItemStatus.AUCTION_IN_PROGRESS.ToString(),
                            StatusTo = ItemStatus.PAYMENT_PENDING.ToString(),
                            StatusChangedById = 1,
                            StatusChangeReason = $"Item won by user {highestBid.UserId}"
                        });

                        item.WonDate = DateTime.Today;
                        item.PaymentDueDate = DateTime.Today.AddDays(7);

                        _notificationRepo.Create<Notification>(e => e.Id == item.SellerId, $"Sản phẩm {item.Name} đã được đấu giá thành công");

                        _notificationRepo.Create<Notification>(e => e.Id == highestBid.UserId, $"Bạn đã thắng được sản phẩm {item.Name}");
                    }
                    else
                    {
                        report.UnauctionedItems++;
                        item.Status = ItemStatus.RE_AUCTION_PENDING;
                        item.StatusChanges!.Add(new StatusChange()
                        {
                            StatusFrom = ItemStatus.AUCTION_IN_PROGRESS.ToString(),
                            StatusTo = ItemStatus.RE_AUCTION_PENDING.ToString(),
                            StatusChangedById = 1,
                            StatusChangeReason = $"Item auction failed"
                        });

                        item.HighestBid = null;

                        _notificationRepo.Create<Notification>(e => e.Id == item.SellerId, $"Sản phẩm {item.Name} đã không được đấu giá thành công");
                    }
                }
            }

            _vxDbc.SaveChanges();

            _logger.LogInformation("Auction Ended");

            return Task.CompletedTask;
        }
    }
}
