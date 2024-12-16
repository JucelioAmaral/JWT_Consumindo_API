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

        private void btnTestarDiretoDaquiDoServico_Click(object sender, EventArgs e)
        {
            try
            {
                RegistraLog.Log(Nivel.Acao, "btnTestarDiretoDaquiDoServico_Click. Teste iniciando...");
                a.AutenticaConsumidorApi();
                txtStatusConexao.Text = Global.statusConexaoAPI;
                dgvEquipamentos.DataSource = Global.equipamentos;
            }
            catch (Exception ex)
            {
                RegistraLog.Log(Nivel.Acao, "btnTestarDiretoDaquiDoServico_Click. Exception: " + ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                RegistraLog.Log(Nivel.Acao, "btnLimpar_Click. Limpando...");
                txtStatusConexao.Text = string.Empty;
                Global.statusConexaoAPI = string.Empty;
                Global.autenticado = false;
                dgvEquipamentos.DataSource = null;
            }
            catch (Exception ex)
            {
                RegistraLog.Log(Nivel.Acao, "btnLimpar_Click. Exception: " + ex.Message);
            }
        }
    }
}
