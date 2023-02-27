using System;
//Biblioteca para trabalhar com arquivos
using System.IO;

namespace CursoCSharp.API {
    public static class ExtensaoString {
        public static string ParseHome(this string path) {
            //Verifica se a plataforma é linux ou mac
            string home = (Environment.OSVersion.Platform == PlatformID.Unix ||
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                //Variavel de ambiente linux e mac
                ? Environment.GetEnvironmentVariable("Home")
                //Variavel de ambiente windows
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            //Substitui o tio pelo valor encontrar na variavel de ambiente home
            return path.Replace("~", home);
        }
    }

    class PrimeiroArquivo {
        public static void Executar() {
            //Deve usar o @ antes da cadeia de string, para que ele possa entender
            //se vc usar um /t por exemplo, ele vai enter que é TAB
            //se usar /n ele vai pular a linha, por isso usar o @ antes de caminho com barra, por exemplo
            //Colocando o @, o programa entende a stgring de maneira literal
            //Passo a minha variavel para o método parsehome
            var path = @"~/primeiro_arquivo.txt".ParseHome();
            //Se o arquivo não existir
            if (!File.Exists(path)) {
                //Ele vai criar o arquivo
                //AO usar o using o C# fechara todos os recursos que ele utilizou 
                //para criar e popular o arquivo
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                    Console.WriteLine("Arquivo criado e salvo no " + path);
                }
            }

            //Adicionando mais texto
            using (StreamWriter sw = File.AppendText(path)) {
                sw.WriteLine("");
                sw.WriteLine("É possivel");
                sw.WriteLine("colocar mais texto");
                sw.WriteLine(":)");
                Console.WriteLine("Carga incremental efetuada no " + path);
            }
        }
    }
}
