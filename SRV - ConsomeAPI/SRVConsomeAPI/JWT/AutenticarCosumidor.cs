using Newtonsoft.Json;
using SRV_ConsomeAPI.Eventlog;
using SRV_ConsomeAPI.JWT;
using SRV_ConsomeAPI.Model;
using SRV_ConsomeAPI.WebApiEquipamentos;
using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static SRV_ConsomeAPI.Eventlog.NivelEnums;

namespace SRVConsomeAPI
{
    [ServiceBehavior(Name = "SRVConsomeAPI", InstanceContextMode = InstanceContextMode.Single)]

    public class AutenticarCosumidor
    {
        public string _urlBase;
        ConsomeApi consome = new ConsomeApi();
        HttpResponseMessage respToken;


        /// <summary>
        /// Recursividade para verificar conexão com a API e fazer a autenticação.
        /// </summary>
        public void AutenticaConsumidorApi()
        {
            while (!Global.autenticado)
            {
                if (AutenticaConsumidorNaApi())
                {
                    Global.autenticado = true;
                    break;
                }
                Thread.Sleep(5000);
            }
        }

        /// <summary>
        /// Autentica Consumidor Na Api
        /// </summary>
        private bool AutenticaConsumidorNaApi()
        {

            try
            {
                RegistraLog.Log(Nivel.Info, "AutenticaConsumidorNaApi: Iniciando...");
                _urlBase = ConfigurationSettings.AppSettings["UrlBase"];
                RegistraLog.Log(Nivel.Info, "AutenticaConsumidorNaApi: urlBase= " + _urlBase);

                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));
                    try
                    {
                        respToken = client.PostAsync( // Post para autenticar primeiramente.
                            _urlBase + "login", new StringContent(
                                JsonConvert.SerializeObject(new
                                {
                                    UserID = ConfigurationSettings.AppSettings["UserID"], // Este usuário está no appsettings.json desse projeto
                                    AccessKey = ConfigurationSettings.AppSettings["AccessKey"] // Esta chave está no appsettings.json desse projeto
                                }), Encoding.UTF8, "application/json")).Result;
                        string conteudo = respToken.Content.ReadAsStringAsync().Result;
                        Global.autenticado = true;
                        Global.statusConexaoAPI = "Conectado na API: " + _urlBase;
                        RegistraLog.Log(Nivel.Info, "AutenticaConsumidorNaApi: autenticado = " + Global.autenticado + ", Token= " + conteudo);
                        consome.ConsomeDadosNaApi(_urlBase, respToken);
                        return true;
                    }
                    catch (Exception ex)
                    {
                        RegistraLog.Log(Nivel.Erro, "AutenticaConsumidorNaApi: autenticado = " + Global.autenticado);
                        RegistraLog.Log(Nivel.Erro, "AutenticaConsumidorNaApi: Exception:" + ex.Message);
                        return false;
                    }

                }
            }
            catch (Exception ex)
            {
                Global.statusConexaoAPI = "Erro ao autenticar com a API";
                RegistraLog.Log(Nivel.Erro, "AutenticaConsumidorNaApi: Exception= " + ex.Message);
                return false;
            }
        }
    }
}
