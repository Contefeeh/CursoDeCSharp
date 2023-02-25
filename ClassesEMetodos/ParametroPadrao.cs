using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ParametroPadrao {
        public static int Somar(int a = 1, int b = 1) {
            return a + b;
        }
        public static void Executar() {
            Console.WriteLine(Somar(a: 10, b:23)) ;
            Console.WriteLine(Somar(a:50));
            Console.WriteLine(Somar(b:100));
            Console.WriteLine(Somar());
        }
    }
}
