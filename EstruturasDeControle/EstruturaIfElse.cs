using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIfElse {
        public static void Executar(){
            Console.WriteLine("Digite a nota do aluno: ");
            double.TryParse(Console.ReadLine(),out double nota);

            if (nota > 7.0) {
                Console.WriteLine("Aprovador, Parabens!");
            } else {
                Console.WriteLine("Recuperação.");
            }
        }
    }
}
