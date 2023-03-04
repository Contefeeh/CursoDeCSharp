using System;
using System.IO;

namespace CursoCSharp.API {
    class ExemploPath {
        public static void Executar() {
            var arquivo = @"~/exemplo_path_arquivo.txt".ParseHome();
            var pasta = @"~/exemplo_path_pasta".ParseHome();

            if (!File.Exists(arquivo)) {
                using (StreamWriter sw = File.CreateText(arquivo)) {
                    sw.WriteLine("Um novo arquivo criado!");
                }
            }

            if (!Directory.Exists(pasta)) {
                Directory.CreateDirectory(pasta);
            }

            //Informações de Arquivos
            //Para ver a extensão do arquivo
            Console.WriteLine("Extensão: " + Path.GetExtension(arquivo));
            //Para ver o nome do arquivo
            Console.WriteLine("Nome do Arquivo: " + Path.GetFileName(arquivo));
            //Arquivo sem extensão
            Console.WriteLine("Nome do Arquivo Sem Extensão: " + Path.GetFileNameWithoutExtension(arquivo));
            //Diretorio do arquivo
            Console.WriteLine("Diretório do Arquivo: " + Path.GetDirectoryName(arquivo));
            //Ele diz se o arquivo tem extensão - bool
            Console.WriteLine("Tem Extensão? " + Path.HasExtension(arquivo));

            //Informações de Diretorios
            //Verifica se a pasta tem extensão. no caso de uma pasta vai ser sempre não
            Console.WriteLine("Pasta tem Extensão? " + Path.HasExtension(pasta));
            //Caminho completo da pasta
            Console.WriteLine("Caminho Completo Pasta: " + Path.GetFullPath(pasta));
            //Mostra a raiz da onde a pasta esta localizada
            Console.WriteLine("Root da Pasta: " + Path.GetPathRoot(pasta));

        }
    }
}
