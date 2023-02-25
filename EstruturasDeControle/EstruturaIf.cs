using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIf {
        public static void Executar() {
            bool bomComportamento = false;

            Console.WriteLine("Digite a nota do aluno: ");
            double.TryParse(Console.ReadLine(), out double nota);

            Console.WriteLine("Possui bom comportamento (S/N)");
            string entrada = Console.ReadLine().ToUpper();

            if (entrada == "S") {
                bomComportamento = true;
            }

            if (nota >= 9 && bomComportamento) {
                Console.WriteLine("Honra ao mérito!");
            }
        }
    }
}
