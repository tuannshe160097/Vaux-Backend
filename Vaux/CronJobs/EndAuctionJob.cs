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
        private readonly ILogger<EndAuctionJob> _logger;
        private readonly IAuctionSessionRepo _repo;

        public EndAuctionJob(ILogger<EndAuctionJob> logger, IAuctionSessionRepo repo)
        {
            _logger = logger;
            _repo = repo;
        }

        public Task Execute(IJobExecutionContext context)
        {
            _repo.EndSession();

            _logger.LogInformation("Auction Ended");

            return Task.CompletedTask;
        }
    }
}
