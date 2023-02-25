using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosPorReferencia {
        //Valor ref
        public static void AlterarRef(ref int numero) {
            numero = numero + 1000;
        }

        //Valor out
        public static void AlterarOut(out int numero) {
            numero = 0;
            numero = numero + 15;
        }
        public static void Executar() {
            //Valor ref
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine("Valor de A(ref): "+ a);
            //Valor out
            AlterarOut(out int b);
            Console.WriteLine("Valor de B(out): " + b);
        }
    }
}
