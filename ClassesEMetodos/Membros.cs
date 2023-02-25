using System;


namespace CursoCSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {
          //*Classe           *Construtor      
            Pessoa fulano = new Pessoa();
            fulano.Nome = "Felipe";
            fulano.Idade = 36;

            //Console.WriteLine("{0} tem {1} anos de idade.",fulano.Nome,fulano.Idade);

            fulano.ApresentarNoConsole();

            var sicrano = new Pessoa();

            Console.WriteLine("Insira o nome de Sicrano: ");
            var usuarioNome = Console.ReadLine();

            Console.WriteLine("insira a idade de Sicrano: ");
            int.TryParse(Console.ReadLine(), out int usuarioIdade);

            sicrano.Nome = usuarioNome;
            sicrano.Idade = usuarioIdade;

            var apresentacaoSicrano = sicrano.Apresentar();

            Console.WriteLine(apresentacaoSicrano);

        }
    }
}
