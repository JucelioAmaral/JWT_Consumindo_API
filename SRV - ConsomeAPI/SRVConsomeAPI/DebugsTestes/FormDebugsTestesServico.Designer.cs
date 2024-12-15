
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatusConexao = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Status Conexão com a API:";
            // 
            // txtStatusConexao
            // 
            this.txtStatusConexao.Location = new System.Drawing.Point(224, 307);
            this.txtStatusConexao.Name = "txtStatusConexao";
            this.txtStatusConexao.Size = new System.Drawing.Size(318, 20);
            this.txtStatusConexao.TabIndex = 3;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(421, 21);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 34);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FormDebugsTestesServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 344);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtStatusConexao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEquipamentos);
            this.Controls.Add(this.btnTestarDiretoDaquiDoServico);
            this.Name = "FormDebugsTestesServico";
            this.Text = "Form de Debugs e Testes do Servico";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestarDiretoDaquiDoServico;
        private System.Windows.Forms.DataGridView dgvEquipamentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatusConexao;
        private System.Windows.Forms.Button btnLimpar;
    }
}