using Microsoft.Extensions.Logging;
using Quartz;
using System.Threading.Tasks;
using Vaux.DbContext;
using Vaux.Models.Enums;
using Vaux.Models;
using Vaux.Repositories.Interface;
using Vaux.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace Vaux.CronJobs
{
    [DisallowConcurrentExecution]
    public class EndAuctionJob : IJob
    {
        private readonly ILogger<EndAuctionJob> _logger;
        private readonly IAuctionSessionRepo _repo;
        private readonly IHubContext<BidHub> _bidHub;

        public EndAuctionJob(ILogger<EndAuctionJob> logger, IAuctionSessionRepo repo, IHubContext<BidHub> hub)
        {
            _logger = logger;
            _repo = repo;
            _bidHub = hub;
        }

        public Task Execute(IJobExecutionContext context)
        {
            _repo.EndSession();
            _bidHub.Clients.All.SendAsync("AuctionEnd");

            _logger.LogInformation("Auction Ended");

            return Task.CompletedTask;
        }
    }
}
