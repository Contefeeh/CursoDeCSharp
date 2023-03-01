using System;
using System.IO;

namespace CursoCSharp.API {
    class LendoArquivos {
        public static void Executar() {
            //Parse home transforma o ~ pelo caminho raiz do usuario
            var path = @"~/lendo_arquivos.txt".ParseHome();

            //Se o arquivo não existir, ele cria (if)
            if (!File.Exists(path)) {
                using (StreamWriter sw = File.AppendText(path)) {
                    sw.WriteLine("Produto;Preço;Qtde");
                    sw.WriteLine("Caneta Bic;3.59;89");
                    sw.WriteLine("Borracha Branca;2.89;27");
                }
            }

            //Tentado ler o arquivo
            try {
                using (StreamReader sr = new StreamReader(path)) {
                    //Lendo o arquivo
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            } catch (Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}
