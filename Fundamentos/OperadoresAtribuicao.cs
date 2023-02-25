using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresAtribuicao {
        public static void Executar() {
            var num1 = 3;//Atribuiu valor a variavel
            num1 = 7;//Substituiu o valor da variavel
            num1 += 10; //Numero recebe o próprio valor de numero + 10 (Atribuição de 10 ao numero acima)
            num1 -= 3;//Retira 3 do valor acima
            num1 *= 5;//Multiplica o valor de cima por 5
            num1 /= 2;//Divide o valor acima por 2

            Console.WriteLine(num1);

            //Atribuição por cópia
            int a = 1;
            int b = a;

            a++;//Atribuição via operador unário (Atribuição de 1)
            b--;//Atribuição negativa via operador unário (Atribuição de -1)

            Console.WriteLine($"Valor de a = {a} | Valor de b = {b}");

            //Atribuição por referência
            //O que vc mudar em uma interfere na outra
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine($"Nome da variavel c = {c.nome} | Nome da variavel d = {d.nome}");
        }
    }
}
