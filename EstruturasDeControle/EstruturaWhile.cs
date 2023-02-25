using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaWhile {
        public static void Executar() {
            Random random = new Random();

            //Valor randomico entre 1 e 15(16 não é gerado)
            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativaRestantes = 5;
            int tentativas = 0;

            while (tentativaRestantes > 0 && !numeroEncontrado) {
                Console.WriteLine("Insira seu palpite entre 1 e 15: ");
                int.TryParse(Console.ReadLine(), out int palpite);

                tentativas++;
                tentativaRestantes--;

                if (numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    //Pegando a cor do console e armazenando em uma variavel de aferição automatica
                    var corAnterior = Console.BackgroundColor;
                    //Alterando a cordo de fundo do console
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero enontrado em {0} tentativas. Parabens!", tentativas);
                    //Voltando a cor do console
                    Console.BackgroundColor = corAnterior;
                } else if (palpite > numeroSecreto) {
                    Console.WriteLine("Valor é menor, tente novamente.");
                    Console.WriteLine("tentativas restantes {0}", tentativas);
                } else {
                    Console.WriteLine("Valor é maior, tente novamente.");
                    Console.WriteLine("tentativas restantes {0}", tentativas);
                }
            }

        }
    }
}
