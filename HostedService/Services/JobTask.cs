using HostedService.Scheduling;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace HostedService.Services
{
    public class JobTask : IScheduledTask
    {
        //Configuração para executar a cada 2 minutos
        public string Schedule => "*/2 * * * *";

        public async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            Debug.WriteLine("Job teste executando!");
        }
    }
}
