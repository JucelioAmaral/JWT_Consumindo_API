using System;
using System.ServiceModel;


namespace SRVConsomeAPI
{
    [ServiceBehavior(Name = "SRVConsomeAPI", InstanceContextMode = InstanceContextMode.Single)]

    public class clsControleProcessamento
    {
        public void IniciarProcessamento()
        {
            try
            {
                Console.WriteLine("IniciarProcessamento");                
                //ThreadStart start = new ThreadStart(checkEmails.VerificarEmailsPendentes);
                //threadVerificacao = new Thread(start);
                //threadVerificacao.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine("OnStart: Erro ao IniciarProcessamento: " + e.Message);
            }            

        }

        public void FinalizarProcessamento()
        {
        }
    }
}