using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaDoWhile {
        public static void Executar() {
            string nome;
            string pergunta;

            //Usado para uma quantdade indeterminada de repetições
            do {
                Console.WriteLine("Qual o seu nome?");
                nome = Console.ReadLine();
                Console.WriteLine("Seja bem vindo, {0}!", nome);

                Console.WriteLine("Deseja continuar? ()S/N)");
                pergunta = Console.ReadLine();
            } while (pergunta.ToUpper() == "S");
        }
    }
}
