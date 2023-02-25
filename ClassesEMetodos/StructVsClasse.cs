using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public struct SPonto {
        public int X;
        public int Y;
    }

    public class CPonto {
        public int X;
        public int Y;
    } 

    class StructVsClasse {
        public static void Executar() {
            //Struct
            SPonto ponto1 = new SPonto { X = 2, Y = 3 };
            SPonto copiaPonto1 = ponto1;//Atribuição feita por valor

            ponto1.X = 3;
            Console.WriteLine("Exemplo Struct - Por valor");
            Console.WriteLine("Valor de X: {0} e Valor de Y: {1}",ponto1.X,ponto1.Y);
            Console.WriteLine("Copia Ponto 1 - Valor de X: {0} ",copiaPonto1.X);

            //Classe
            CPonto ponto2 = new CPonto { X = 2, Y = 3 };
            CPonto copiaPonto2 = ponto2;//Atribuição feita por valor


            ponto2.X = 3;
            Console.WriteLine("Exemplo Classe - Por referência");
            Console.WriteLine("Valor de X: {0} e Valor de Y: {1}", ponto2.X, ponto2.Y);
            Console.WriteLine("Copia Ponto 1 - Valor de X: {0} ", copiaPonto2.X);
        }

    }
}
