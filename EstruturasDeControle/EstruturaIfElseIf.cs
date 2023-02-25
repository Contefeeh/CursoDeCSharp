using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIfElseIf {
        public static void Executar() {
            Console.WriteLine("Digite a note do aluno: ");

            double.TryParse(Console.ReadLine(), out double nota);

            if (nota > 9) {
                Console.WriteLine("Aprovado! Quadro de Honra ...");
            } else if (nota >= 7.0) {
                Console.WriteLine("Aprovado!");
            } else if (nota >= 5.0) {
                Console.WriteLine("Recuperação.");
            } else {
                Console.WriteLine("Reprovado.");
            }
        }
    }
}
