using System;
using System.IO;

namespace CursoCSharp.API {
    class Diretorios {
        public static void Executar() {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var dirProjeto = @"~/source/repos/CursoCSharp".ParseHome();

            //Esses são métodos estaticos, porque não foi necessario criar instancias para utiliza-los
            if (Directory.Exists(novoDir)) {
                //O true demonstra que o delete vai eleminar o diretorio de maneira recursiva
                Directory.Delete(novoDir, true);
            }

            if (Directory.Exists(novoDirDestino)) {
                Directory.Delete(novoDirDestino,true);
            }

            //Para criar diretorio
            Directory.CreateDirectory(novoDir);
            //Mostra a data e hora que foi criado o diretorio
            Console.WriteLine("Criação de Diretorio: " + Directory.GetCreationTime(novoDir));
            //Lista as pastas do diretorio
            Console.WriteLine("===Pastas===================================================");
            //O resultado abaixo é um array de strings
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach (var pasta in pastas) {
                Console.WriteLine(pasta);
            }

            //Imprimir os arquivos do diretorio
            Console.WriteLine("\n\n===Arquivos===============================================");
            //Resultado é um array de strings
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach (var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }

            //Pasta raiz
            Console.WriteLine("\n\n===Raiz===================================================");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            //Movendo o diretorio de origem para destino
            Directory.Move(novoDir,novoDirDestino);
            Console.WriteLine("\n\n==Movendo de origem para destino==========================");
            Console.WriteLine($"Foi movido de {novoDir} para {novoDirDestino}.");
        }
    }
}
