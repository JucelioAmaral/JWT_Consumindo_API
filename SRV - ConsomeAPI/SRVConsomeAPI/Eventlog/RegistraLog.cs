using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using static SRV_ConsomeAPI.Eventlog.NivelEnums;

namespace SRV_ConsomeAPI.Eventlog
{
    [ServiceBehavior(Name = "SRVConsomeAPI", InstanceContextMode = InstanceContextMode.Single)]

    public class RegistraLog
    {
        public static void Log(Nivel nivel, string strMensagem)
        {
            try
            {
                string nomeExecutavel = System.AppDomain.CurrentDomain.FriendlyName;
                //nomeExecutavel = nomeExecutavel.Split('.')[0];
                string strNomeArquivo = "ArquivoLog.txt";
                string caminhoPastaLog = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"EventLog");

                string caminhoExe = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                if (!Directory.Exists(caminhoPastaLog)) Directory.CreateDirectory(caminhoPastaLog);
                string caminhoArquivo = Path.Combine(caminhoPastaLog, strNomeArquivo);

                if (!File.Exists(caminhoArquivo))
                {
                    FileStream arquivo = File.Create(caminhoArquivo);
                    arquivo.Close();
                }

                using (StreamWriter w = File.AppendText(caminhoArquivo))
                {
                    AppendLog(strMensagem, w);
                }
                
            }
            catch (Exception ex)
            {
                RegistraLog.Log(Nivel.Erro, ex.Message);
                Console.WriteLine(ex.Message);
            }
        }        

        private static void AppendLog(string logMensagem, TextWriter txtWriter)
        {
            try
            {                
                txtWriter.Write(DateTime.Now + ": " + logMensagem + "\r\n");
            }
            catch (Exception ex)
            {
                RegistraLog.Log(Nivel.Erro, ex.Message);
                throw ex;
            }
        }
    }
}
