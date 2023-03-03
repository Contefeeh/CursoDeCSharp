using System;
using System.IO;


namespace CursoCSharp.API {
    class ExemploDirectoryInfo {
        public static void Executar() {
            var dirProjeto = @"~/source/repos/CursoCSharp".ParseHome();
            var dirInfo = new DirectoryInfo(dirProjeto);

            //Cria o Diretorio, caso não exista
            if (!dirInfo.Exists) {
                dirInfo.Create();
            }

            Console.WriteLine("==Arquivos============================");
            var arquivos = dirInfo.GetFiles();
            foreach (var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("\n\n==Diretórios==========================");
            var pastas = dirInfo.GetDirectories();
            foreach (var pasta in pastas) {
                Console.WriteLine(pasta);
            }

            //Demais informações
            Console.WriteLine("\n\n==Demais Informações possiveis=========");
            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            //Retorna a pasta pai da que eu estou olhando. Pode encadear varios
            Console.WriteLine(dirInfo.Parent.Parent);
        }
    }
}
