using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresUnarios {
        public static void Executar() {
            var valorNegativo = -5;
            var num1 = 2;
            var num2 = 3;
            var booleano = true;

            Console.WriteLine("Valor original antes do (-) -5. Após colocar a inversão de sinal: " + -valorNegativo); //Inverte o sinal
            Console.WriteLine("Negação Lógica(!): " + !booleano); //Negação Lógica

            //Incremento pós fixado
            num1++;
            Console.WriteLine("Incremento com o operador(++) após a variavel: {0}",num1);

            //Incremento pré fixado
            --num1;
            Console.WriteLine("Incremento com o operador(--) antes da variavel: {0}",num1);

            //o pré fixado é decrementado antes da comparação e o pós fixado depois
            Console.WriteLine(num1++ == --num2);

        }
    }
}
