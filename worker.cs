using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace App.WorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time} at workflow testing v1" , DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}