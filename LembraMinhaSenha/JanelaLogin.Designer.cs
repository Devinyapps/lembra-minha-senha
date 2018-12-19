namespace LembraMinhaSenha
{
    partial class JanelaLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JanelaLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNomeUsuario = new System.Windows.Forms.TextBox();
            this.TxtSenhaMestre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.BtEntrar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.CbNovoUsuario = new System.Windows.Forms.CheckBox();
            this.LbDica = new System.Windows.Forms.Label();
            this.BtCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha Mestre :";
            // 
            // TxtNomeUsuario
            // 
            this.TxtNomeUsuario.Location = new System.Drawing.Point(97, 24);
            this.TxtNomeUsuario.Name = "TxtNomeUsuario";
            this.TxtNomeUsuario.Size = new System.Drawing.Size(156, 20);
            this.TxtNomeUsuario.TabIndex = 2;
            // 
            // TxtSenhaMestre
            // 
            this.TxtSenhaMestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenhaMestre.Location = new System.Drawing.Point(97, 50);
            this.TxtSenhaMestre.Name = "TxtSenhaMestre";
            this.TxtSenhaMestre.PasswordChar = '*';
            this.TxtSenhaMestre.Size = new System.Drawing.Size(156, 20);
            this.TxtSenhaMestre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email :";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Enabled = false;
            this.TxtEmail.Location = new System.Drawing.Point(97, 99);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(156, 20);
            this.TxtEmail.TabIndex = 5;
            // 
            // BtEntrar
            // 
            this.BtEntrar.Location = new System.Drawing.Point(97, 136);
            this.BtEntrar.Name = "BtEntrar";
            this.BtEntrar.Size = new System.Drawing.Size(78, 31);
            this.BtEntrar.TabIndex = 7;
            this.BtEntrar.Text = "Entrar";
            this.BtEntrar.UseVisualStyleBackColor = true;
            this.BtEntrar.Click += new System.EventHandler(this.BtEntrar_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(181, 136);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(72, 31);
            this.BtCancelar.TabIndex = 8;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // CbNovoUsuario
            // 
            this.CbNovoUsuario.AutoSize = true;
            this.CbNovoUsuario.Location = new System.Drawing.Point(162, 76);
            this.CbNovoUsuario.Name = "CbNovoUsuario";
            this.CbNovoUsuario.Size = new System.Drawing.Size(91, 17);
            this.CbNovoUsuario.TabIndex = 9;
            this.CbNovoUsuario.Text = "Novo Usuário";
            this.CbNovoUsuario.UseVisualStyleBackColor = true;
            this.CbNovoUsuario.CheckedChanged += new System.EventHandler(this.CbNovoUsuario_CheckedChanged);
            // 
            // LbDica
            // 
            this.LbDica.AutoSize = true;
            this.LbDica.Location = new System.Drawing.Point(16, 181);
            this.LbDica.Name = "LbDica";
            this.LbDica.Size = new System.Drawing.Size(179, 13);
            this.LbDica.TabIndex = 10;
            this.LbDica.Text = "Insira um email válido para backup...";
            this.LbDica.Visible = false;
            // 
            // BtCadastrar
            // 
            this.BtCadastrar.Enabled = false;
            this.BtCadastrar.Location = new System.Drawing.Point(19, 136);
            this.BtCadastrar.Name = "BtCadastrar";
            this.BtCadastrar.Size = new System.Drawing.Size(72, 31);
            this.BtCadastrar.TabIndex = 11;
            this.BtCadastrar.Text = "Cadastrar";
            this.BtCadastrar.UseVisualStyleBackColor = true;
            this.BtCadastrar.Click += new System.EventHandler(this.BtCadastrar_Click_1);
            // 
            // JanelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(274, 234);
            this.Controls.Add(this.BtCadastrar);
            this.Controls.Add(this.LbDica);
            this.Controls.Add(this.CbNovoUsuario);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtEntrar);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSenhaMestre);
            this.Controls.Add(this.TxtNomeUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JanelaLogin";
            this.Text = "Conectando...";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JanelaLogin_FormClosed);
            this.Load += new System.EventHandler(this.JanelaLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNomeUsuario;
        private System.Windows.Forms.TextBox TxtSenhaMestre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button BtEntrar;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.CheckBox CbNovoUsuario;
        private System.Windows.Forms.Label LbDica;
        private System.Windows.Forms.Button BtCadastrar;
    }
}