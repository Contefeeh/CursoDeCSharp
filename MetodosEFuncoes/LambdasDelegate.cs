using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    //O delegate pode estar dentro ou fora da classe
    //Exemplo delegate
    //Para utilizar o delegate é necessario respeitar a assinatura do método
    //A assinatura consiste em: Valores de entrada(x,y) e o double retorno.
    delegate double Operacao(double x, double y);
    class LambdasDelegate {
        public static void Executar() {
            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;

            Console.WriteLine("Soma: " + sum(3, 3));
            Console.WriteLine("Subtração: " + sub(4, 3));
            Console.WriteLine("Multiplicação: " + mult(3, 3));
        }
    }
}
