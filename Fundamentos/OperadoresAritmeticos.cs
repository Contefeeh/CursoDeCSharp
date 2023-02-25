using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresAritmeticos {
        public static void Executar() {
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);

            Console.WriteLine($"Preço total é de R${total}. Se aplicar o desconto o preço será de R${totalComDesconto}.");

            //IMC
            double peso = 91.2;
            double altura = 1.80;
            double imc = peso / Math.Pow(altura, 2);//Potência de dois
            Console.WriteLine($"Sua altura: {altura} | Seu peso: {peso} | Seu IMC: {imc}");

            //Numero par ou impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("Par: {0}/2 tem resto {1}",par,par % 2);//O Módulo(%) tras o resto da divisão
            Console.WriteLine("Impar: {0}/2 tem resto {1}",impar,impar % 2);//O Módulo(%) tras o resto da divisão
        }
    }
}
