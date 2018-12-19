namespace LembraMinhaSenha
{
    partial class JanelaConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaConfig));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtServidor = new System.Windows.Forms.TextBox();
            this.BtConectar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuração do servidor de banco de dados.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insira o endereço IP do servidor de banco de dados.";
            // 
            // TxtServidor
            // 
            this.TxtServidor.Location = new System.Drawing.Point(97, 69);
            this.TxtServidor.Name = "TxtServidor";
            this.TxtServidor.Size = new System.Drawing.Size(100, 20);
            this.TxtServidor.TabIndex = 2;
            this.TxtServidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtConectar
            // 
            this.BtConectar.Location = new System.Drawing.Point(97, 107);
            this.BtConectar.Name = "BtConectar";
            this.BtConectar.Size = new System.Drawing.Size(100, 29);
            this.BtConectar.TabIndex = 3;
            this.BtConectar.Text = "Conectar";
            this.BtConectar.UseVisualStyleBackColor = true;
            this.BtConectar.Click += new System.EventHandler(this.BtConectar_Click);
            // 
            // JanelaConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(302, 158);
            this.Controls.Add(this.BtConectar);
            this.Controls.Add(this.TxtServidor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JanelaConfig";
            this.Text = "Configurar Servidor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JanelaConfig_FormClosed);
            this.Load += new System.EventHandler(this.JanelaConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtServidor;
        private System.Windows.Forms.Button BtConectar;
    }
}