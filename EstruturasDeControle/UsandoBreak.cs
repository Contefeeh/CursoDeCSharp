using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class UsandoBreak {
        public static void Executar() {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O número que queremos é {0}.",numero);

            //Uma vez que encontrei o numero desejado, ele sai do For através do break
            for (int i = 1; i <= 50; i++) {

                Console.WriteLine("Chave {0} é o numero que queremos? ", i);

                if (i == numero) {
                    Console.WriteLine("Sim :)");
                    break;
                } else { 
                    Console.WriteLine("Não :("); 
                }
            }
        }
    }
}
