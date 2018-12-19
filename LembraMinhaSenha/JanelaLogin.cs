using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LembraMinhaSenha
{
    public partial class JanelaLogin : Form
    {
        public Usuario Usuario { get; set; }
        public BancoDeDados Banco { get; set; }
        public bool LoginConfirmado { get; set; }

        public JanelaLogin()
        {
            InitializeComponent();
        }

        private void BtCadastrar_Click(object sender, EventArgs e)
        {
        }

        private void CbNovoUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if(CbNovoUsuario.Checked == true)
            {
                TxtEmail.Enabled = true;
                LbDica.Text = "Insira um email válido para backup...";
                LbDica.Visible = true;
                BtCadastrar.Enabled = true;
                BtEntrar.Enabled = false;
            }
            else
            {
                TxtEmail.Enabled = false;
                LbDica.Visible = false;
                BtEntrar.Enabled = true;
                BtCadastrar.Enabled = false;
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void JanelaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (LoginConfirmado == false)
            {
                Application.Exit();
            }
        }

        private void BtEntrar_Click(object sender, EventArgs e)
        {               
            Usuario = new Usuario(TxtNomeUsuario.Text, TxtSenhaMestre.Text);
            if (Banco.LoginValido(Usuario))
            {
                LoginConfirmado = true;
                this.Close();
            }
            else
            {               
                LbDica.Text = "Nome de usuario ou senha incorretos...";
                LbDica.Visible = true;
            }
        }

        private void JanelaLogin_Load(object sender, EventArgs e)
        {
            ArquivoConfig arqConfiguracao = new ArquivoConfig();
            if(arqConfiguracao.ArquivoConfigExiste() == false)
            {
                JanelaConfig janelaConfig = new JanelaConfig();
                janelaConfig.ShowDialog();
            }
            Banco = new BancoDeDados(arqConfiguracao.LerDados());
            LoginConfirmado = false;
        }

        private void BtCadastrar_Click_1(object sender, EventArgs e)
        {
            ArquivoConfig arqConfig = new ArquivoConfig();
            if (ConferirCampos())
            { 
                Usuario = new Usuario(TxtNomeUsuario.Text, TxtEmail.Text, TxtSenhaMestre.Text);
                if (Banco.ExisteUsuario(Usuario))
                {
                    LbDica.Text = "O Nome de usuario selecionado já existente.\nEscolha outro nome para seu usuario.";
                }
                else
                {
                    Banco.CadastrarUsuario(Usuario);
                    MessageBox.Show("Usuario " + TxtNomeUsuario.Text + " cadastrado com sucesso.", "Cadastro efetuado...");
                    LoginConfirmado = true;
                    this.Close();
                }
            }
            else
            {
                LbDica.Text = "Insira todos os dados necessários\npara o cadastro.";
            }
            
            
        }

        private bool ConferirCampos()
        {
            bool confere = false;
            if ((string.IsNullOrEmpty(TxtNomeUsuario.Text) == false && !string.IsNullOrWhiteSpace(TxtNomeUsuario.Text)) && (string.IsNullOrEmpty(TxtSenhaMestre.Text) == false && !string.IsNullOrWhiteSpace(TxtSenhaMestre.Text)) && (string.IsNullOrEmpty(TxtEmail.Text) == false && !string.IsNullOrWhiteSpace(TxtEmail.Text)))
            {
                confere = true;
            }
            return confere;
        }
    }
}
