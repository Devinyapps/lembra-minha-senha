using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LembraMinhaSenha
{
    public class Usuario
    {

        public string Nome { get; set;  }
        public string Email { get; set; }
        public string SenhaMestre { get; set; }
        public string IdUsuario { get; set; }

        public Usuario(string nome, string email, string senhaMestre)
        {
            Nome = nome;
            Email = email;
            SenhaMestre = senhaMestre;
        }
        public Usuario()
        {    
        }

        public Usuario(string nome, string senhaMestre)
        {
            Nome = nome;
            SenhaMestre = senhaMestre;
        }

        public Usuario(string id = "", string nome = "", string senhaMestre = "", string email = "")
        {
            IdUsuario = id;
            Nome = nome;
            Email = email;
            SenhaMestre = senhaMestre;
        }

        
        
    }
}
