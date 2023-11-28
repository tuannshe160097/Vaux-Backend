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
    public class BidOverdueJob : IJob
    {
        private readonly VxDbc _vxDbc;
        private readonly ILogger<BidOverdueJob> _logger;
        private readonly INotificationRepo _notificationRepo;

        public BidOverdueJob(VxDbc vxDbc, ILogger<BidOverdueJob> logger, INotificationRepo notificationRepo)
        {
            _vxDbc = vxDbc;
            _logger = logger;
            _notificationRepo = notificationRepo;
        }

        public Task Execute(IJobExecutionContext context)
        {
            var overdueItems = _vxDbc.Items.Where(e => e.PaymentDueDate <= DateTime.Today && e.Status == ItemStatus.PAYMENT_PENDING).ToList();
            foreach (var item in overdueItems)
            {
                item.Status = ItemStatus.RE_AUCTION_PENDING;
                item.StatusChanges!.Add(new StatusChange()
                {
                    StatusFrom = ItemStatus.PAYMENT_PENDING.ToString(),
                    StatusTo = ItemStatus.RE_AUCTION_PENDING.ToString(),
                    StatusChangedById = 1,
                    StatusChangeReason = $"User {item.WonBid!.UserId} did not pay"
                });

                item.WonBid!.User.Deleted = DateTime.Now;

                _notificationRepo.Create<Notification>(e => e.Id == item.SellerId, $"Sản phẩm {item.Name} đã được đưa lại vào danh sách chờ do người mua không trả tiền");


                item.WonBid = null;
                item.WonDate = null;
                item.PaymentDueDate = null;
            }

            _vxDbc.SaveChanges();

            return Task.CompletedTask;
        }
    }
}
