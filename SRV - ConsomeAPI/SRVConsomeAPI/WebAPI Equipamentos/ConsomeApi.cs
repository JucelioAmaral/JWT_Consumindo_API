using Newtonsoft.Json;
using SRV_ConsomeAPI.Eventlog;
using SRV_ConsomeAPI.Model;
using SRVConsomeAPI.DebugsTestes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static SRV_ConsomeAPI.Eventlog.NivelEnums;

namespace SRV_ConsomeAPI.WebAPI_Equipamentos
{
    public class ConsomeApi
    {
        //List<Equipamento> equipamentosLista = new List<Equipamento>();

        public void ObtemEquipamentosNaApi(string url, HttpClient client)
        {
            try
            {
                RegistraLog.Log(Nivel.Info, "ObtemEquipamentosNaApi...");
                HttpResponseMessage response = client.GetAsync(
                    url + "equipamento/BuscaEquipamentosStatus").Result;

                RegistraLog.Log(Nivel.Info, "ObtemEquipamentosNaApi:StatusCode= " + response.StatusCode);
                
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
