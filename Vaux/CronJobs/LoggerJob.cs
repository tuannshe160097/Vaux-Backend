using Quartz;

namespace Vaux.CronJobs
{
    [DisallowConcurrentExecution]
    public class LoggerJob : IJob
    {
        private readonly ILogger<LoggerJob> _logger;

        public LoggerJob(ILogger<LoggerJob> logger)
        {
            _logger = logger;
        }

        public Task Execute(IJobExecutionContext context)
        {
            _logger.LogInformation("Hello world!");
            return Task.CompletedTask;
        }
    }
}
