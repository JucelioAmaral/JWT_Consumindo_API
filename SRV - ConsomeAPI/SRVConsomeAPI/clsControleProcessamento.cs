using SRV_ConsomeAPI;
using SRV_ConsomeAPI.Eventlog;
using System;
using System.Collections.Generic;
using System.Threading;
using static SRV_ConsomeAPI.Eventlog.NivelEnums;

namespace SRVConsomeAPI
{

    public class clsControleProcessamento
    {
        Thread threadColetaLog;
        private static List<Thread> listaThreads = new List<Thread>();

        public void IniciarProcessamento()
        {
            try
            {
                RegistraLog.Log(Nivel.Info, "IniciarProcessamento: Iniciando processamento...");                
                AutenticarCosumidor autentica = new AutenticarCosumidor();
                ThreadStart start = new ThreadStart(autentica.AutenticaConsumidorNaApi);
                threadColetaLog = new Thread(start);
                threadColetaLog.Start();
            }
            catch (Exception ex)
            {
                RegistraLog.Log(Nivel.Erro,"OnStart: Erro ao IniciarProcessamento: " + ex.Message);                
            }            

        }

        public void FinalizarProcessamento()
        {
            try
            {
                foreach (Thread thread in listaThreads)
                {
                    thread.Abort();
                }
                RegistraLog.Log(Nivel.Info, "FinalizarProcessamento: Finalizando processamento...");                
            }
            catch (Exception ex)
            {
                RegistraLog.Log(Nivel.Erro, "FinalizarProcessamento: Exception: " + ex.Message);
            }
        }
    }
}