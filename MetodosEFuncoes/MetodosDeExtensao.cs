using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    public static class ExtensoesInteiro {
        //O que diz que é uma função de extensão é a junção do this com um tipo (no caso int)
        //Essa logica serve para int, double etc
        public static int Soma(this int num, int outroValorNumerico) {
            return num + outroValorNumerico;
        }

        public static int Subtracao(this int num, int outroValorNumerico) {
            return num - outroValorNumerico;
        }
    }

    class MetodosDeExtensao {
        public static void Executar() {
            int numero = 5;
            Console.WriteLine(numero.Soma(3));
            Console.WriteLine(numero.Subtracao(2));
            Console.WriteLine(2.Subtracao(1));
            Console.WriteLine(9.Soma(10));
        }
    }
}
