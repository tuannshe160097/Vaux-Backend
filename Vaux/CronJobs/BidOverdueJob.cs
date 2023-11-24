using Microsoft.Extensions.Logging;
using Quartz;
using System.Threading.Tasks;
using Vaux.DbContext;
using Vaux.Models;
using Vaux.Models.Enums;

namespace Vaux.CronJobs
{
    [DisallowConcurrentExecution]
    public class BidOverdueJob : IJob
    {
        private readonly VxDbc _vxDbc;
        private readonly ILogger<BidOverdueJob> _logger;

        public BidOverdueJob(VxDbc vxDbc, ILogger<BidOverdueJob> logger)
        {
            _vxDbc = vxDbc;
            _logger = logger;
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

                item.Seller.Notifications!.Add(new Notification()
                {
                    Content = $"Sản phẩm {item.Name} đã được đưa lại vào danh sách chờ do người mua không trả tiền",
                    UserId = item.SellerId
                });

                item.WonBid = null;
                item.WonDate = null;
                item.PaymentDueDate = null;
            }

            _vxDbc.SaveChanges();

            return Task.CompletedTask;
        }
    }
}
