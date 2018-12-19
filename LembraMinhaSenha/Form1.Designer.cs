namespace LembraMinhaSenha
{
    partial class JanelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaPrincipal));
            this.BtArmazenar = new System.Windows.Forms.Button();
            this.BtLembrar = new System.Windows.Forms.Button();
            this.TxtChave = new System.Windows.Forms.TextBox();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LbStatus = new System.Windows.Forms.Label();
            this.LbUsuario = new System.Windows.Forms.Label();
            this.CbNovaSenha = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtArmazenar
            // 
            this.BtArmazenar.Enabled = false;
            this.BtArmazenar.Location = new System.Drawing.Point(21, 185);
            this.BtArmazenar.Name = "BtArmazenar";
            this.BtArmazenar.Size = new System.Drawing.Size(97, 36);
            this.BtArmazenar.TabIndex = 0;
            this.BtArmazenar.Text = "Armazenar";
            this.BtArmazenar.UseVisualStyleBackColor = true;
            this.BtArmazenar.Click += new System.EventHandler(this.BtGuardar_Click);
            // 
            // BtLembrar
            // 
            this.BtLembrar.Location = new System.Drawing.Point(124, 185);
            this.BtLembrar.Name = "BtLembrar";
            this.BtLembrar.Size = new System.Drawing.Size(97, 36);
            this.BtLembrar.TabIndex = 1;
            this.BtLembrar.Text = "Lembrar";
            this.BtLembrar.UseVisualStyleBackColor = true;
            this.BtLembrar.Click += new System.EventHandler(this.BtLembrar_Click);
            // 
            // TxtChave
            // 
            this.TxtChave.Location = new System.Drawing.Point(21, 52);
            this.TxtChave.Name = "TxtChave";
            this.TxtChave.Size = new System.Drawing.Size(200, 20);
            this.TxtChave.TabIndex = 3;
            // 
            // TxtLogin
            // 
            this.TxtLogin.Enabled = false;
            this.TxtLogin.Location = new System.Drawing.Point(21, 120);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(200, 20);
            this.TxtLogin.TabIndex = 4;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Enabled = false;
            this.TxtSenha.Location = new System.Drawing.Point(21, 159);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(200, 20);
            this.TxtSenha.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Palavra Chave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email/Usuario/Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Senha";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupToolStripMenuItem,
            this.MenuAjuda,
            this.MenuSobre});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(244, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.backupToolStripMenuItem.Text = "Backup";
            this.backupToolStripMenuItem.Click += new System.EventHandler(this.BackupToolStripMenuItem_Click);
            // 
            // MenuAjuda
            // 
            this.MenuAjuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MenuAjuda.Name = "MenuAjuda";
            this.MenuAjuda.Size = new System.Drawing.Size(50, 20);
            this.MenuAjuda.Text = "Ajuda";
            this.MenuAjuda.Click += new System.EventHandler(this.MenuAjuda_Click);
            // 
            // MenuSobre
            // 
            this.MenuSobre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MenuSobre.Name = "MenuSobre";
            this.MenuSobre.Size = new System.Drawing.Size(49, 20);
            this.MenuSobre.Text = "Sobre";
            this.MenuSobre.Click += new System.EventHandler(this.MenuSobre_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Status :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Usuario :";
            // 
            // LbStatus
            // 
            this.LbStatus.AutoSize = true;
            this.LbStatus.Location = new System.Drawing.Point(67, 265);
            this.LbStatus.Name = "LbStatus";
            this.LbStatus.Size = new System.Drawing.Size(16, 13);
            this.LbStatus.TabIndex = 12;
            this.LbStatus.Text = "...";
            // 
            // LbUsuario
            // 
            this.LbUsuario.AutoSize = true;
            this.LbUsuario.Location = new System.Drawing.Point(67, 243);
            this.LbUsuario.Name = "LbUsuario";
            this.LbUsuario.Size = new System.Drawing.Size(16, 13);
            this.LbUsuario.TabIndex = 13;
            this.LbUsuario.Text = "...";
            // 
            // CbNovaSenha
            // 
            this.CbNovaSenha.AutoSize = true;
            this.CbNovaSenha.Location = new System.Drawing.Point(135, 78);
            this.CbNovaSenha.Name = "CbNovaSenha";
            this.CbNovaSenha.Size = new System.Drawing.Size(86, 17);
            this.CbNovaSenha.TabIndex = 14;
            this.CbNovaSenha.Text = "Nova Senha";
            this.CbNovaSenha.UseVisualStyleBackColor = true;
            this.CbNovaSenha.CheckedChanged += new System.EventHandler(this.CbNovaSenha_CheckedChanged);
            // 
            // JanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(244, 309);
            this.Controls.Add(this.CbNovaSenha);
            this.Controls.Add(this.LbUsuario);
            this.Controls.Add(this.LbStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.TxtChave);
            this.Controls.Add(this.BtLembrar);
            this.Controls.Add(this.BtArmazenar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "JanelaPrincipal";
            this.Text = "Lembra Minha Senha";
            this.Load += new System.EventHandler(this.JanelaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtArmazenar;
        private System.Windows.Forms.Button BtLembrar;
        private System.Windows.Forms.TextBox TxtChave;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuAjuda;
        private System.Windows.Forms.ToolStripMenuItem MenuSobre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LbStatus;
        private System.Windows.Forms.Label LbUsuario;
        private System.Windows.Forms.CheckBox CbNovaSenha;
    }
}

