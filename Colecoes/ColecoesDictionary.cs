using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesDictionary {
        public static void Executar() {
            //Utiliza o generic do System.Collection
            //Aceita repetição na string, mas não aceita na chave int
            var filmes = new Dictionary<int, string>();
            filmes.Add(2000, "Gladiador");
            filmes.Add(2001, "Dracula");
            filmes.Add(2004, "Os Incriveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004)) {
                //Caso a chave não exista, vai dar um problema
                Console.WriteLine("2004: " + filmes[2004]);
                //Resolve o problema acima
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004));
            }

            //Verifica o conteudo dentro do dictionary
            Console.WriteLine(filmes.ContainsValue("Dracula"));
            //Remove o item do dictionary e retorna true or false
            Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

            //Outra forma de pegar um valor no dictionary
            //Utiliza o out pra fazer a saida para uma variavel do tipo string
            //E retorna true or false para dizer se achou a chave
            Console.WriteLine(filmes.TryGetValue(2006, out string Filme2006));
            Console.WriteLine(Filme2006);

            //Formas de percorrer um dictionary
            Console.WriteLine("Usando foreach para percorrer a chave");
            foreach (var chave in filmes.Keys) {
                Console.WriteLine(chave);
            }
            Console.WriteLine("Usando foreach para percorrer o valor");
            foreach (var valor in filmes.Values) {
                Console.WriteLine(valor);
            }
            Console.WriteLine("Usando foreach para percorrer chave e valor da maneira mais complicada");
            foreach (KeyValuePair<int,string> filme in filmes) {
                Console.WriteLine("{0} de {1}",filme.Value,filme.Key);
            }
            Console.WriteLine("Usando foreach para percorrer chave e valor de maneira mais simples");
            foreach (var filme in filmes) {
                Console.WriteLine("{0} de {1}", filme.Value, filme.Key);
            }
        }
    }
}
