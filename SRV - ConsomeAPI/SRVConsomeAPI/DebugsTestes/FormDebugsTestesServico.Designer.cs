
namespace SRVConsomeAPI.DebugsTestes
{
    partial class FormDebugsTestesServico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTestarDiretoDaquiDoServico = new System.Windows.Forms.Button();
            this.dgvEquipamentos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTestarDiretoDaquiDoServico
            // 
            this.btnTestarDiretoDaquiDoServico.Location = new System.Drawing.Point(26, 21);
            this.btnTestarDiretoDaquiDoServico.Name = "btnTestarDiretoDaquiDoServico";
            this.btnTestarDiretoDaquiDoServico.Size = new System.Drawing.Size(145, 34);
            this.btnTestarDiretoDaquiDoServico.TabIndex = 0;
            this.btnTestarDiretoDaquiDoServico.Text = "Testar direto do serviço";
            this.btnTestarDiretoDaquiDoServico.UseVisualStyleBackColor = true;
            this.btnTestarDiretoDaquiDoServico.Click += new System.EventHandler(this.btnTestarDiretoDaquiDoServico_Click);
            // 
            // dgvEquipamentos
            // 
            this.dgvEquipamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipamentos.Location = new System.Drawing.Point(22, 101);
            this.dgvEquipamentos.Name = "dgvEquipamentos";
            this.dgvEquipamentos.Size = new System.Drawing.Size(520, 177);
            this.dgvEquipamentos.TabIndex = 1;
            // 
            // FormDebugsTestesServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 318);
            this.Controls.Add(this.dgvEquipamentos);
            this.Controls.Add(this.btnTestarDiretoDaquiDoServico);
            this.Name = "FormDebugsTestesServico";
            this.Text = "Form de Debugs e Testes do Servico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestarDiretoDaquiDoServico;
        private System.Windows.Forms.DataGridView dgvEquipamentos;
    }
}