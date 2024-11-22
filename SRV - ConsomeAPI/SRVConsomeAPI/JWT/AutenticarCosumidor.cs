using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using SRV_ConsomeAPI.Eventlog;
using SRV_ConsomeAPI.JWT;
using SRV_ConsomeAPI.WebAPI_Equipamentos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using static SRV_ConsomeAPI.Eventlog.NivelEnums;

namespace SRVConsomeAPI
{
    [ServiceBehavior(Name = "SRVConsomeAPI", InstanceContextMode = InstanceContextMode.Single)]

    public class AutenticarCosumidor
    {
        public string _urlBase;
        ConsomeApi consome = new ConsomeApi();

        /// <summary>
        /// Autentica Consumidor Na Api
        /// </summary>
        [Obsolete]
        public void AutenticaConsumidorNaApi()
        {
            RegistraLog.Log(Nivel.Info, "AutenticaConsumidorNaApi: Iniciando...");
            _urlBase = ConfigurationSettings.AppSettings["UrlBase"];
            RegistraLog.Log(Nivel.Info, "AutenticaConsumidorNaApi: _urlBase= " + _urlBase);

            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(
                        new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage respToken = client.PostAsync( // Post para autenticar primeiramente.
                        _urlBase + "login", new StringContent(
                            JsonConvert.SerializeObject(new
                            {
                                UserID = ConfigurationSettings.AppSettings["UserID"], // Este usuário está no appsettings.json desse projeto
                                AccessKey = ConfigurationSettings.AppSettings["AccessKey"] // Esta chave está no appsettings.json desse projeto
                            }), Encoding.UTF8, "application/json")).Result;

                    string conteudo = respToken.Content.ReadAsStringAsync().Result;
                    RegistraLog.Log(Nivel.Info, "AutenticaConsumidorNaApi: Token= " + conteudo);                    

                    if (respToken.StatusCode == HttpStatusCode.OK)
                    {
                        RegistraLog.Log(Nivel.Info, "AutenticaConsumidorNaApi: StatusCode= " + respToken.StatusCode);
                        Token token = JsonConvert.DeserializeObject<Token>(conteudo);
                        if (token.Authenticated)
                        {
                            client.DefaultRequestHeaders.Authorization =
                                new AuthenticationHeaderValue("Bearer", token.AccessToken);

                            consome.ObtemEquipamentosNaApi(_urlBase, client);
                        }
                        RegistraLog.Log(Nivel.Info, "AutenticaConsumidorNaApi: Finalizada.");                                             
                    }
                }
            }
            catch (Exception ex)
            {
                RegistraLog.Log(Nivel.Erro, "AutenticaConsumidorNaApi: Exception= " + ex.Message);
            }
        }
    }
}
