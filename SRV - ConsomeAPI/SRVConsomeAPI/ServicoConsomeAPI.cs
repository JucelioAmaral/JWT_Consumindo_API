﻿using SRV_ConsomeAPI.Eventlog;
using SRVConsomeAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace SRVConsomeAPI
{
    public partial class ServicoConsomeAPI : ServiceBase
    {
        public ServicoConsomeAPI()
        {
            InitializeComponent();
        }        

        protected override void OnStart(string[] args)
        {
            try
            {
                //EventLog.WriteEntry("Em OnStart. Serviço iniciando...", EventLogEntryType.Information);
                RegistraLog.Log(NivelEnums.Nivel.Info,"Em OnStart. Serviço iniciando...");
                clsControleProcessamento controle = new clsControleProcessamento();
                controle.IniciarProcessamento();
            }
            catch (Exception e)
            {
                //EventLog.WriteEntry("Exception em OnStart.", EventLogEntryType.Error);
                RegistraLog.Log(NivelEnums.Nivel.Erro,"Exception em OnStart." + e.Message);                
            }
        }

        protected override void OnStop()
        {
            try
            {
                //EventLog.WriteEntry("Em OnStop. Serviço finalizado.", EventLogEntryType.Information);
                RegistraLog.Log(NivelEnums.Nivel.Info,"Em OnStop. Serviço finalizado.");
            }
            catch (Exception e)
            {
                //EventLog.WriteEntry("Exception em OnStop.", EventLogEntryType.Error);
                RegistraLog.Log(NivelEnums.Nivel.Erro,"Exception em OnStop." + e.Message);                
            }
        }
    }
}
