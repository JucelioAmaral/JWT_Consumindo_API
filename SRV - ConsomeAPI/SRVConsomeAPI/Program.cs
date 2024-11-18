using SRVConsomeAPI;
using SRVConsomeAPI.DebugsTestes;
using System.ServiceProcess;
using System.Windows.Forms;

namespace SRVConsomeAPI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
#if DEBUG

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDebugsTestesServico());
#else                
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new ServicoConsomeAPI()
            };
            ServiceBase.Run(ServicesToRun);
#endif
        }
    }
}
