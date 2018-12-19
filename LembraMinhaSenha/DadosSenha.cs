using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LembraMinhaSenha
{
    public class DadosSenha
    {
        public string IdDado { get; set; }
        public string IdUsuario { get; set; }
        public string PalavraChave { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        public DadosSenha()
        {
        }

        public DadosSenha(string idDado, string idUsuario, string chave, string login, string senha)
        {
            IdDado = idDado;
            IdUsuario = idUsuario;
            PalavraChave = chave;
            Login = login;
            Senha = senha;
        }
        public DadosSenha(string idUsuario, string chave, string login, string senha)
        {
            IdUsuario = idUsuario;
            PalavraChave = chave;
            Login = login;
            Senha = senha;
        }

        public DadosSenha(string palavraChave, string login, string senha)
        {
            PalavraChave = palavraChave;
            Login = login;
            Senha = senha;
        }

        public DadosSenha(string chave, string senha)
        {
            PalavraChave = chave;
            Senha = senha;
        }

        
    }
}
