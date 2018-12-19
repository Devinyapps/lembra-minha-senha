using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace LembraMinhaSenha
{
    public class BancoDeDados
    {
        public MySqlConnection Conexao { get; set; }
        public MySqlCommand Cmd { get; set; }
        public string StrConexao { get; set; }
        public Usuario Usuario { get; set; }
        public bool ConexaoStatus { get; set; }

        public BancoDeDados(string ipservidor)
        {
            StrConexao = string.Format("server={0};user=usuariolms;database=lms;password=2.0lms2.0;port=3306", ipservidor);
            Conexao = new MySqlConnection(StrConexao);
            Conectar();
            Desconectar();
        }

        public void TesteSqliteCadastro(Usuario usuario)
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string caminho = Path.Combine(desktop, "lms.db");
            string strconect = string.Format("Data Source= {0}", caminho);
            SQLiteConnection con = new SQLiteConnection(strconect);
            con.Open();         
            string comandosql = "INSERT INTO usuarios (nome_usua, emai_usua, s_mest_usua) VALUES (@nome, @email, @senha);";
            var cmd = new SQLiteCommand(comandosql, con);
            cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@email", usuario.Email);
            cmd.Parameters.AddWithValue("@senha", usuario.SenhaMestre);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void CriarBancoDeDados()
        {
            Conectar();
            string sqlTabelaUsuarios = "create table if not exists usuarios(" +
                "id_usua int not null primary key auto_increment," +
                "nome_usua varchar(30) not null," +
                "s_mest_usua varchar(30)," +
                "emai_usua varchar(30));";

            string sqlTabelaDados = "create table if not exists dados(" +
                "id_dado int not null primary key auto_increment," +
                "id_usua int not null," +
                "p_chav_dado varchar(30) not null," +
                "logi_dado varchar(50)," +
                "senh_dado varchar(50) not null," +
                "foreign key(id_usua) references usuarios(id_usua));";
            string strTabelaLicenca = "create table if not exists licenca(" +
                "id_lice int not null primary key auto_increment," +
                "dada_lice date not null);";
            string dataIstall = "insert into licenca (dada_lice) select curdate();";
            Cmd = new MySqlCommand(sqlTabelaUsuarios, Conexao);
            Cmd.ExecuteNonQuery();
            Cmd = new MySqlCommand(sqlTabelaDados, Conexao);
            Cmd.ExecuteNonQuery();
            Cmd = new MySqlCommand(strTabelaLicenca, Conexao);
            Cmd.ExecuteNonQuery();
            Cmd = new MySqlCommand(dataIstall, Conexao);
            Cmd.ExecuteNonQuery();
            Desconectar();
            
        }

        public void CriarbancoDeDadosSqlite()
        {
            var caminho = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "lms.db");
            var cami = string.Format("Data Source = {0}", caminho);
            var conexao = new SQLiteConnection(cami);
            conexao.Open();
            string sqlTabelaUsuarios = "create table if not exists usuarios(" +
                "id_usua integer not null primary key autoincrement," +
                "nome_usua varchar(30) not null," +
                "s_mest_usua varchar(30)," +
                "emai_usua varchar(30));";

            string sqlTabelaDados = "create table if not exists dados(" +
                "id_dado integer not null primary key autoincrement," +
                "id_usua integer not null," +
                "p_chav_dado varchar(30) not null," +
                "logi_dado varchar(50)," +
                "senh_dado varchar(50) not null," +
                "foreign key(id_usua) references usuarios(id_usua));";
            var cmd = new SQLiteCommand(sqlTabelaUsuarios, conexao);
            cmd.ExecuteNonQuery();
            cmd = new SQLiteCommand(sqlTabelaDados, conexao);
            cmd.ExecuteNonQuery();
            conexao.Close();
        }


        private void Conectar()
        {
            try
            {
                Conexao.Open();
                ConexaoStatus = true;
            }
            catch
            {
                MessageBox.Show("Banco de dados não conectado...\n\n* Reinicie o programa ou\n* Reinicie o computador servidor ou\n* Modifique o arquivo de configuração do servidor","Erro de Conexão");
                ConexaoStatus = false;
                Application.Exit();
            }          
        }
        private void Desconectar()
        {
            Conexao.Close();
        }

        public void CadastrarUsuario(Usuario usuario)
        {
            Conectar();
            string comandosql = string.Format("INSERT INTO usuarios (nome_usua, emai_usua, s_mest_usua) VALUES ('{0}','{1}','{2}');", usuario.Nome, usuario.Email, usuario.SenhaMestre);
            Cmd = new MySqlCommand(comandosql, Conexao);
            Cmd.ExecuteNonQuery();
            Desconectar();
        }

        public void CadastrarSenha(DadosSenha dadosSenha)
        {
            try
            {
                Conectar();
                string comandosql = string.Format("insert into dados (id_usua, p_chav_dado, logi_dado, senh_dado) values ('{0}','{1}','{2}','{3}');", dadosSenha.IdUsuario, dadosSenha.PalavraChave, dadosSenha.Login, dadosSenha.Senha);
                Cmd = new MySqlCommand(comandosql, Conexao);
                Cmd.ExecuteNonQuery();
                Desconectar();
                MessageBox.Show("Senha amazenada", "Sucesso...");
            }
            catch
            {
                MessageBox.Show("Erro na conexão do banco de dados", "Erro...");
            }
            
        }

        public bool ExisteUsuario(Usuario usuario)
        {
            Conectar();
            string comandosql = string.Format("SELECT * FROM usuarios WHERE nome_usua = '{0}';", usuario.Nome);
            Cmd = new MySqlCommand(comandosql, Conexao);
            MySqlDataReader leitor = Cmd.ExecuteReader();
            bool temosDados = leitor.Read();
            leitor.Close(); 
            Desconectar();
            if (temosDados)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ExisteUsuarioSqlite(Usuario usuario)
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string caminho = Path.Combine(desktop, "lms.db");
            string strconect = string.Format("Data Source = {0}", caminho);
            var conexao = new SQLiteConnection(strconect);
            conexao.Open();
            string comandosql = "SELECT * FROM usuarios WHERE nome_usua = @username;";
            var cmd = new SQLiteCommand(comandosql, conexao);
            cmd.Parameters.AddWithValue("@username", usuario.Nome);
            SQLiteDataReader leitor = cmd.ExecuteReader();
            bool temosDados = leitor.Read();
            leitor.Close();
            conexao.Close();
            if (temosDados)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool ExisteChave(DadosSenha dadoSenha, Usuario usuario)
        {
            Conectar();
            string comandosql = string.Format("SELECT p_chav_dado FROM dados WHERE p_chav_dado = '{0}' AND id_usua = {1};", dadoSenha.PalavraChave, usuario.IdUsuario);
            Cmd = new MySqlCommand(comandosql, Conexao);
            MySqlDataReader leitor = Cmd.ExecuteReader();
            bool temosDados = leitor.Read();
            leitor.Close();
            Desconectar();
            if (temosDados)
            {
                MessageBox.Show("Insira uma palavra chave diferente\npois esta já é usada no sistema.","Erro...");
                return true;             
            }
            else
            {
                return false;
            }
        }

        public DadosSenha LembrarSenha(Usuario usuario, string chave)
        {
            DadosSenha dados = null;
            Conectar();
            string comandosql = string.Format("select * from dados where p_chav_dado = '{0}' and id_usua = {1};", chave, usuario.IdUsuario);
            Cmd = new MySqlCommand(comandosql, Conexao);
            MySqlDataReader leitor = Cmd.ExecuteReader();
            if (leitor.Read())
            {
                dados = new DadosSenha(leitor[0].ToString(), leitor[1].ToString(), leitor[2].ToString(), leitor[3].ToString(), leitor[4].ToString());
            }
            else
            {
                MessageBox.Show("Chave inexistente no banco de dados", "Erro...");
            }
            leitor.Close();
            Desconectar();
            return dados;
        }

        public bool LoginValido(Usuario usuario)
        {
            Conectar();
            string comandosql = string.Format("SELECT nome_usua, s_mest_usua FROM usuarios WHERE nome_usua = '{0}' and s_mest_usua = '{1}';", usuario.Nome, usuario.SenhaMestre);
            Cmd = new MySqlCommand(comandosql, Conexao);
            MySqlDataReader leitor = Cmd.ExecuteReader();
            bool temosDados = leitor.Read();
            leitor.Close();
            Desconectar();
            if (temosDados)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Usuario DadosDoUsuario(string nomeDoUsuario)
        {
            Conectar();
            string comandosql = string.Format("SELECT * FROM usuarios WHERE nome_usua = '{0}';", nomeDoUsuario);
            Cmd = new MySqlCommand(comandosql, Conexao);
            MySqlDataReader leitor = Cmd.ExecuteReader();
            Usuario user = new Usuario();
            if ( leitor.Read())
            {
                user = new Usuario(leitor[0].ToString(), leitor[1].ToString(), leitor[2].ToString(), leitor[3].ToString());
                
            }
            Desconectar();
            return user;

        }

        public string BackupUsuario(Usuario usuario)
        {
            Conectar();
            string comandosql = string.Format("select p_chav_dado, logi_dado, senh_dado from dados where id_usua = {0}", usuario.IdUsuario);
            Cmd = new MySqlCommand(comandosql, Conexao);
            MySqlDataReader leitor = Cmd.ExecuteReader();
            string dadosBackup = " CHAVE | LOGIN | SENHA\n";
            while (leitor.Read())
            {
                dadosBackup += string.Format("{0} | {1} | {2}\n", leitor[0].ToString(), leitor[1].ToString(), leitor[2].ToString());
            }
            Desconectar();
            return dadosBackup;
        }
    }
}
