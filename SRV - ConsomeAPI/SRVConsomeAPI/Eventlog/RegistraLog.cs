using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SRV_ConsomeAPI.Eventlog
{
    [ServiceBehavior(Name = "SRVConsomeAPI", InstanceContextMode = InstanceContextMode.Single)]

    public class RegistraLog
    {
        private static string caminhoExe = string.Empty;

        public static bool Log(string strMensagem, string strNomeArquivo = "ArquivoLog.txt")
        {
            try
            {
                caminhoExe = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                string caminhoArquivo = Path.Combine(caminhoExe, strNomeArquivo);

                if (!File.Exists(caminhoArquivo))
                {
                    FileStream arquivo = File.Create(caminhoArquivo);
                    arquivo.Close();
                }

                using (StreamWriter w = File.AppendText(caminhoArquivo))
                {
                    AppendLog(strMensagem, w);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
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
                throw ex;
            }
        }
    }
}
