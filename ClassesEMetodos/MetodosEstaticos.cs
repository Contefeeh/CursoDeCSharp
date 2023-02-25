using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class CalculadoraEstatica {
        //Método da classe
        public static int Somar(int a, int b) {
            return a + b;
        }

        //Método de instância
        public int Multiplicar(int a, int b) {
            return a * b;
        }
    }
    class MetodosEstaticos {
        public static void Executar() {
            //Exemplo Método static
            //Não precisa ser instanciado
            var resultadoStatic = CalculadoraEstatica.Somar(10, 10);
            Console.WriteLine($"O resultado da soma através de " +
                $"uma método 'static' da classe Calculadora (10 + 10 = {resultadoStatic})");

            //Exemplo instanciado
            var resultadoInstanciado = new CalculadoraEstatica();
            Console.WriteLine($"O resultado da multiplicação através de " +
                $"uma variavel 'instanciada' da classe Calculadora (9 * 8 = {resultadoInstanciado.Multiplicar(9,8)})");
        }
    }
}
