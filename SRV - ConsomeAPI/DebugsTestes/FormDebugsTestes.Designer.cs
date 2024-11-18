
namespace DebugsTestes
{
    partial class FormDebugTeste
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
            this.btnTestar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestar
            // 
            this.btnTestar.Location = new System.Drawing.Point(126, 91);
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Size = new System.Drawing.Size(144, 41);
            this.btnTestar.TabIndex = 0;
            this.btnTestar.Text = "Testar do projeto de Teste";
            this.btnTestar.UseVisualStyleBackColor = true;
            this.btnTestar.Click += new System.EventHandler(this.btnTestar_Click);
            // 
            // FormDebugTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 228);
            this.Controls.Add(this.btnTestar);
            this.Name = "FormDebugTeste";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Debug e teste do Projeto Form tbm para testes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestar;
    }
}

