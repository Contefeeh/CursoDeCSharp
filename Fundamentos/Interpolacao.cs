using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Interpolacao {
        public static void Executar() {
            string nome = "Notebook Gamer Destruidor";
            string marca = "Dell";
            double preco = 5800.00;

            //Forma crua de interpolação
            Console.WriteLine("O " + nome + " da marca " + marca + " custa R$" + preco + ".");

            //Forma dois
            Console.WriteLine("O {0} da marca {1} custa R${2}.", nome, marca, preco);

            //Forma três
            Console.WriteLine($"O {nome} da marca {marca} custa R${preco}");
            Console.WriteLine($"1 + 1 = {1 + 1}");
        }
    }
}
