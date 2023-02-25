using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    //Uma interface ja é implicidamente abstrata
    //Toda classe que quiser ser aderente a uma interface, precisa implementar todos seus metodos
    //Uma interface tambem pode implementar outra interface
    interface OperacaoBinaria {
        //Esse método abstrato é por padrão publico
         int Operacao(int a, int b);
    }

    interface Teste {
        string Texto(string a);
    }


    //Uma classe pode implementar diversas interfaces
    class Soma : OperacaoBinaria, Teste {
        //Obrigatoriamente o membro de uma interface é publico
        // Nesse caso não precisa usar o ":base" para repassar o valor para a interface
        public int Operacao(int a, int b) {
            return a + b;
        }

        public string Texto(string a) {
            return $"Texto: {a}";
        }
    }

    class Subtracao : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a - b;
        }
    }

    class Multiplicao : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a * b;
        }
    }

    class Calculadora {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria> {
            new Soma(),
            new Subtracao(),
            new Multiplicao()
        };

        public string ExecutarOperacoes(int a, int b) {
            string resultado = "";

            foreach (var op in operacoes){
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a,b)}\n";
            }

            return resultado;    
        }
    }
    class Interface {
        public static void Executar() {
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperacoes(20, 5);
            Console.WriteLine(resultado);
        }
    }
}
