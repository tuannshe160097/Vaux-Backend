using Microsoft.Extensions.Logging;
using Quartz;
using System.Threading.Tasks;
using Vaux.DbContext;
using Vaux.Models;
using Vaux.Models.Enums;
using Vaux.Repositories.Interface;

namespace Vaux.CronJobs
{
    [DisallowConcurrentExecution]
    public class StartAuctionJob : IJob
    {
        private readonly VxDbc _vxDbc;
        private readonly ILogger<StartAuctionJob> _logger;
        private readonly INotificationRepo _notificationRepo;
        private readonly IConfiguration _configuration;

        public StartAuctionJob(VxDbc vxDbc, ILogger<StartAuctionJob> logger, INotificationRepo notificationRepo, IConfiguration configuration)
        {
            _vxDbc = vxDbc;
            _logger = logger;
            _notificationRepo = notificationRepo;
            _configuration = configuration;
        }

        public Task Execute(IJobExecutionContext context)
        {
            var eligibleAuctions = _vxDbc.AuctionSessions.Where(e => e.StartDate.Date == DateTime.Today).ToList();
            foreach (var auc in eligibleAuctions)
            {
                auc.Status = AuctionSessionStatus.ONGOING;
                
                foreach (var item in auc.Items!)
                {
                    item.Status = ItemStatus.AUCTION_IN_PROGRESS;
                    item.OngoingSession = auc;
                    item.StatusChanges!.Add(new StatusChange()
                    {
                        StatusFrom = ItemStatus.AUCTION_PENDING.ToString(),
                        StatusTo = ItemStatus.AUCTION_IN_PROGRESS.ToString(),
                        StatusChangedById = 1,
                        StatusChangeReason = "Start auction"
                    });

                    _notificationRepo.Create<Notification>(e => e.Id == item.SellerId, $"Sản phẩm {item.Name} đã bắt đầu được đấu giá", $"{_configuration["JWT:Audience"]}/seller/detail?itemId={item.Id}");
                }
            }

            _vxDbc.SaveChanges();

            _logger.LogInformation("Auction Started");

            return Task.CompletedTask;
        }
    }
}
