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
    public partial class JanelaConfig : Form
    {
        public bool ServidorConfirmado { get; set; }

        public JanelaConfig()
        {
            InitializeComponent();
        }

        private void BtConectar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TxtServidor.Text) == false || TxtServidor.Text != "")
            {
                ArquivoConfig config = new ArquivoConfig();
                config.Escrever(TxtServidor.Text);
                BancoDeDados banco = new BancoDeDados(TxtServidor.Text);
                if(banco.ConexaoStatus == true)
                {
                    ServidorConfirmado = true;
                    banco.CriarBancoDeDados();
                    this.Close();
                }
                else
                {
                    Application.Exit();
                }
                
            }
            else
            {
                MessageBox.Show("insira o IP do Servidor", "Aviso...");
            }
            
        }

        private void JanelaConfig_Load(object sender, EventArgs e)
        {
            ServidorConfirmado = false;
        }

        private void JanelaConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(ServidorConfirmado == false)
            {
                Application.Exit();
            }
        }
    }
}
