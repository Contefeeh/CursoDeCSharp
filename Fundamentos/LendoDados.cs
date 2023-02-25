using System;
using System.Globalization;//Para usar o sistema americano de ponto como separador de casas decimais

namespace CursoCSharp.Fundamentos {
    class LendoDados {
        public static void Executar() {
            Console.WriteLine("Qual seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu salario? ");
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine($"Nome: {nome} | Idade: {idade} | Salario: R${salario}");

        }
    }
}
