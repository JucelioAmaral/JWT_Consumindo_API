using SRV_ConsomeAPI;
using SRV_ConsomeAPI.Eventlog;
using SRV_ConsomeAPI.Model;
using System;
using System.Windows.Forms;
using static SRV_ConsomeAPI.Eventlog.NivelEnums;

namespace SRVConsomeAPI.DebugsTestes
{
    public partial class FormDebugsTestesServico : Form
    {
        AutenticarCosumidor a = new AutenticarCosumidor();        

        public FormDebugsTestesServico()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void btnTestarDiretoDaquiDoServico_Click(object sender, EventArgs e)
        {
            try
            {
                RegistraLog.Log(Nivel.Info, "btnTestarDiretoDaquiDoServico_Click. Teste iniciando...");
                a.AutenticaConsumidorNaApi();
                dgvEquipamentos.DataSource = Global.equipamentos;
            }
            catch (Exception ex)
            {
                RegistraLog.Log(Nivel.Erro, "btnTestarDiretoDaquiDoServico_Click. Exception: " + ex.Message);
            }
        }
    }
}
