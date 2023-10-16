// <WorkerSnippet>
using System.Threading;
using System.Threading.Tasks;
using CustomConnector.Server;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace CustomConnectorWorkerService
{
    public class Worker : BackgroundService
    {
        public Worker(ILogger<Worker> logger)
        {
            var server = new ConnectorServer();
            server.StartLogger();
            server.Start();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await Task.Delay(1000);
            }
        }
    }
}
// </WorkerSnippet>