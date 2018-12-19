using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LembraMinhaSenha
{
    public class ArquivoConfig
    {
        public string CaminhoArquivo { get; private set; }

        public ArquivoConfig()
        {
            string caminhoPasta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DevinyApps");
            Directory.CreateDirectory(caminhoPasta);
            CaminhoArquivo = Path.Combine(caminhoPasta, "configlms.txt");

        }

        public bool ArquivoConfigExiste()
        {
            if (File.Exists(CaminhoArquivo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Escrever(string texto)
        {
            Stream arquivo = File.Open(CaminhoArquivo, FileMode.OpenOrCreate);
            StreamWriter escritor = new StreamWriter(arquivo);
            escritor.WriteLine(texto);
            escritor.Close();
            arquivo.Close();

        }

        public string LerDados()
        {
            string dado = string.Empty;
            if (File.Exists(CaminhoArquivo))
            {
                Stream arquivo = File.Open(CaminhoArquivo, FileMode.Open);
                StreamReader leitor = new StreamReader(arquivo);
                dado = leitor.ReadLine();
                leitor.Close();
                arquivo.Close();
            }
            return dado;
        }
    }
}
