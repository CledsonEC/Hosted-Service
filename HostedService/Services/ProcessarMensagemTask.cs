using HostedService.Scheduling;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace HostedService.Services
{
    public class ProcessarMensagemTask : IScheduledTask
    {
        //Configuração para executar a cada 1 minuto
        public string Schedule => "*/1 * * * *";

        public async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            HelloWorld();
        }

        void HelloWorld()
        {
            Debug.WriteLine("Hello World!");
        }
    }
}
