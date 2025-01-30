using Newtonsoft.Json;
using SRV_ConsomeAPI.Eventlog;
using SRV_ConsomeAPI.JWT;
using SRV_ConsomeAPI.Model;
using SRVConsomeAPI.DebugsTestes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static SRV_ConsomeAPI.Eventlog.NivelEnums;

namespace SRV_ConsomeAPI.WebApiEquipamentos
{
    public class ConsomeApi
    {
        public void ConsomeDadosNaApi(string urlBase, HttpResponseMessage respostaToken)
        {
            try
            {
                RegistraLog.Log(Nivel.Info, "ConsomeDadosNaApi: Iniciando...");
                using (var client = new HttpClient())
                {
                    RegistraLog.Log(Nivel.Info, "ConsomeDadosNaApi: StatusCode= " + respostaToken.StatusCode);
                    Token token = JsonConvert.DeserializeObject<Token>(respostaToken.Content.ReadAsStringAsync().Result);
                    if (token.Authenticated)
                    {
                        client.DefaultRequestHeaders.Authorization =
                            new AuthenticationHeaderValue("Bearer", token.AccessToken);

                        ObtemEquipamentosNaApi(urlBase, client);
                    }
                    RegistraLog.Log(Nivel.Info, "ConsomeDadosNaApi: Finalizada.");
                }
            }
            catch (Exception ex)
            {
                RegistraLog.Log(Nivel.Erro, "ConsomeDadosNaApi: Exception= " + ex.Message);
            }
        }

        public void ObtemEquipamentosNaApi(string url, HttpClient client)
        {
            try
            {
                RegistraLog.Log(Nivel.Info, "ObtemEquipamentosNaApi...");
                HttpResponseMessage response = client.GetAsync(
                    url + "/api/equipamento/BuscaEquipamentosStatus").Result;                
                
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    RegistraLog.Log(Nivel.Info, "ObtemEquipamentosNaApi:Equipamentos encontrados no banco de dados: " + response.Content.ReadAsStringAsync().Result);                    
                    Global.equipamentos = JsonConvert.DeserializeObject<List<Equipamento>>(response.Content.ReadAsStringAsync().Result);// Preenche a variável (lista de equipamento) global para ser exibida no datagridview
                }
                else
                {
                    RegistraLog.Log(Nivel.Acao, "ObtemEquipamentosNaApi: Token provavelmente expirado!");                    
                }               
            }
            catch (Exception ex)
            {
                RegistraLog.Log(Nivel.Erro, "ObtemEquipamentosNaApi. Exception= " + ex.Message);
            }
        }        
    }
}
