using SRV_ConsomeAPI.Eventlog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DebugsTestes
{
    [ServiceBehavior(Name = "DebugsTestes", InstanceContextMode = InstanceContextMode.Single)]

    public partial class FormDebugTeste : Form
    {
        public FormDebugTeste()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            SRVConsomeAPI.AutenticarCosumidor a = new SRVConsomeAPI.AutenticarCosumidor();
            RegistraLog.Log(NivelEnums.Nivel.Info,"btnTestar_Click. Teste iniciando...");
            a.AutenticaConsumidorApi();
        }
    }
}
