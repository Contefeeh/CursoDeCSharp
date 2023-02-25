using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaSwitch {
        public static void Executar() {
            Console.WriteLine("Avalie o meu atendimento com uma nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(),out int nota);

            switch (nota) {
                case 0:
                    Console.WriteLine("Péssimo");
                    break;
                case 1:
                    Console.WriteLine("Horrivel");
                    break;
                case 2:
                    Console.WriteLine("Semi Horrivel");
                    break;
                case 3:
                    Console.WriteLine("Mediano");
                    break;
                case 4:
                    Console.WriteLine("Quase lá");
                    break;
                case 5:
                    Console.WriteLine("Top");
                    break;
                default:
                    Console.WriteLine("Nota fora do padrão!");
                    break;
            }
            Console.WriteLine("Obrigado pela participação :)");
        }
    }
}
