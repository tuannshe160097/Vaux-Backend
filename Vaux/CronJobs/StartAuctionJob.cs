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
        private readonly ILogger<StartAuctionJob> _logger;
        private readonly IAuctionSessionRepo _repo;

        public StartAuctionJob(ILogger<StartAuctionJob> logger, IAuctionSessionRepo repo)
        {
            _logger = logger;
            _repo = repo;
        }

        public Task Execute(IJobExecutionContext context)
        {
            _repo.StartSession();

            _logger.LogInformation("Auction Started");

            return Task.CompletedTask;
        }
    }
}
