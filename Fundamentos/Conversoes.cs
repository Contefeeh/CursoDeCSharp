using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(inteiro + " = " + quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;//Cachê: Converte explicitamente o valor de double para int
            Console.WriteLine("Nota Truncada: " + notaTruncada);

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade Inserida: {0}, Idade Inteiro: {1}",idadeString,idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Convert.Toint32: {0}",idadeInteiro);

            Console.Write("Digite um numero: ");
            string palavra = Console.ReadLine();
            //int numero;
            int.TryParse(palavra, out int numero);
            Console.WriteLine("Try parse: " + numero);

            //versão melhorada do código acima
            Console.WriteLine("Digite um numero para novo teste: ");
            int.TryParse(Console.ReadLine(), out int numeroDois);
            Console.WriteLine("Try parse método completo: " + numeroDois);
        }
    }
}
