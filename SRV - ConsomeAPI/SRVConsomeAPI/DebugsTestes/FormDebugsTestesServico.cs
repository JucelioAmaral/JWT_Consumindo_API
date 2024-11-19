using SRV_ConsomeAPI.Eventlog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SRV_ConsomeAPI.Eventlog.NivelEnums;

namespace SRVConsomeAPI.DebugsTestes
{
    public partial class FormDebugsTestesServico : Form
    {
        public FormDebugsTestesServico()
        {
            InitializeComponent();
        }

        private void btnTestarDiretoDaquiDoServico_Click(object sender, EventArgs e)
        {            

            clsControleProcessamento c = new clsControleProcessamento();
            RegistraLog.Log(Nivel.Info,"btnTestarDiretoDaquiDoServico_Click. Teste iniciando...");
            c.IniciarProcessamento();
        }
    }
}
