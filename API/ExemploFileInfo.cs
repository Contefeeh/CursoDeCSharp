using System;
using System.IO;

namespace CursoCSharp.API {
    class ExemploFileInfo {
        //Exclui arquivos
        public static void ExcluirSeExistir(params string[] caminhos) {
            foreach (var caminho in caminhos) {
                FileInfo arquivo = new FileInfo(caminho);

                //Se o caminho existir ele deleta
                if (arquivo.Exists) {
                    arquivo.Delete();
                }
            }
        }

        public static void Executar() {
            var caminhoOrigem = @"~/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/arq_destino.txt".ParseHome();
            var caminhoCopia = @"~/arq_copia.txt".ParseHome();

            //Nesse método eu posso passar quantos parametros de caminho existirem
            //Sem isso o código iria quebrar ao rodar uma segunda vez
            ExcluirSeExistir(caminhoOrigem, caminhoCopia,caminhoDestino);

            //Definindo caminho destino
            using (StreamWriter sw = File.CreateText(caminhoOrigem)) {
                sw.WriteLine("Arquivo Original!");
            }
            //File Info
            FileInfo origem = new FileInfo(caminhoOrigem);
            //Nome do arquivo
            Console.WriteLine("Nome do arquivo origem: " + origem.Name);
            //O arquivo é somente leitura?
            Console.WriteLine("O arquivo é somente leitura? " + origem.IsReadOnly);
            //Nome completo do arquivo
            Console.WriteLine("Nome completo do arquivo: " + origem.FullName);
            //Extenção do arquivo
            Console.WriteLine("Qual a extenção do arquivo? " + origem.Extension);
            //Nome diretorio do arquivo
            Console.WriteLine("Qual o nome do diretporio do arquivo" + origem.DirectoryName);

            //Para copiar para outro lugar
            origem.CopyTo(caminhoCopia);
            //Para mover o arquivo para o destino
            origem.MoveTo(caminhoDestino);
        }
    }
}
