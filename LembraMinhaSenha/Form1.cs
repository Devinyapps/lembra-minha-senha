using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace LembraMinhaSenha
{
    public partial class JanelaPrincipal : Form
    {
        public Usuario Usuario { get; private set; }
        public BancoDeDados Banco { get; private set; }
        public ArquivoConfig ArqConfig { get; set; }
        public DadosSenha DadoSenha { get; set; }


        public JanelaPrincipal()
        {
            InitializeComponent();           
        }


        private void BtGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtChave.Text) == false && string.IsNullOrEmpty(TxtSenha.Text) == false)
            {
                DadoSenha = new DadosSenha(Usuario.IdUsuario, TxtChave.Text, TxtLogin.Text, TxtSenha.Text);
                if(Banco.ExisteChave(DadoSenha, Usuario) == false)
                {
                    Banco.CadastrarSenha(DadoSenha);
                    LimparTela();
                    CbNovaSenha.Checked = false;
                }              
                
            }
            else
            {
                LbStatus.Text = "Insira palavra-chave e a senha\npara serem armazenadas";
            }
                
        }

        private void JanelaPrincipal_Load(object sender, EventArgs e)
        {
            JanelaLogin telaLogin = new JanelaLogin();
            telaLogin.ShowDialog();
            ArqConfig = new ArquivoConfig();
            Banco = new BancoDeDados(ArqConfig.LerDados());
            Usuario = Banco.DadosDoUsuario(telaLogin.Usuario.Nome);
            LbStatus.Text = "Conectado";
            LbUsuario.Text = Usuario.Nome;
        }

        private void CbNovaSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (CbNovaSenha.Checked == true)
            {
                TxtSenha.Enabled = true;
                TxtLogin.Enabled = true;
                BtArmazenar.Enabled = true; 
            }
            else
            {

                TxtSenha.Enabled = false;
                TxtLogin.Enabled = false;
                BtArmazenar.Enabled = false;

            }
        }

        public void LimparTela()
        {
            TxtChave.Text = string.Empty;
            TxtLogin.Text = string.Empty;
            TxtSenha.Text = string.Empty;
        }

        private void BtLembrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtChave.Text) == false)
            {
                DadoSenha = Banco.LembrarSenha(Usuario, TxtChave.Text);
                if(DadoSenha != null)
                {
                    string msg = string.Format("Palavra-chave:   {0}\nLogin:   {1}\nSenha:   {2}", DadoSenha.PalavraChave, DadoSenha.Login, DadoSenha.Senha);
                    MessageBox.Show(msg,"Senha encontrada...");
                    LimparTela();
                    CbNovaSenha.Checked = false;
                }

            }
        }

        private void BackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("suporte.devinyapps@gmail.com", "nescau2.0")
            };

            string txtemail = Banco.BackupUsuario(Usuario);
            MailMessage email = new MailMessage("suporte.devinyapps@gmail.com", Usuario.Email, "BACKUP LMS", txtemail);
            try
            {
                smtp.Send(email);
                LbStatus.Text = string.Format("Backup enviado para o endereço:\n{0}", Usuario.Email);
            }
            catch
            {
                MessageBox.Show("Erro no envio do email de backup...","Erro de Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuAjuda_Click(object sender, EventArgs e)
        {
            JanelaAjuda janelaAjuda = new JanelaAjuda();
            janelaAjuda.ShowDialog();
        }

        private void MenuSobre_Click(object sender, EventArgs e)
        {
            JanelaSobre sobre = new JanelaSobre();
            sobre.ShowDialog();
        }
    }
}
