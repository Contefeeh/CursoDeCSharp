using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class UsandoDelegates {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double a, double b) {
            return a + b;
        }

        static void MeuImprimirSoma(double a, double b) {
            Console.WriteLine(a + b);
        }

        public static void Executar() {
            //É possivel associar uma função pré existente com um delegate
            //A unica coisa necessaria é a compatibilidade das assinaturas
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2, 4));

            ImprimirSoma op2 = MeuImprimirSoma;
            op2(5, 8);

            //Funções e Actions tambem podem receber delegates, respestando a assinatura
            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(3, 3));
            //Nesse caso a função esta retornando void, por isso a action funcionou
            Action<double, double> op4 = MeuImprimirSoma;
            op4(2, 6);
        }
    }
}
