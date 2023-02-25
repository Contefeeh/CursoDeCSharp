using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    class CalculadoraComum {
        public int ParametroA;
        public int ParametroB;

        public CalculadoraComum() {

        }


        public int Somar(int a, int b) {
            return a + b;
        }


        public int Subtrair(int a, int b) {
            return a - b;
        }

        public int Multiplicar(int a, int b) {
            return a * b;
        }

        public int Dividir(int a, int b) {
            return a / b;
        }
    }

    class CalculadoraCadeia {
        int memoria;

        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            //Aqui estamos retornando a propria CalculadoraCadeia (this)
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            //Aqui estamos retornando a propria CalculadoraCadeia (this)
            return this;
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            //Aqui estamos retornando a propria CalculadoraCadeia (this)
            return this;
        }

        public CalculadoraCadeia Imprimir() {
            Console.WriteLine($"O valor armazenado na Calculadora Cadeia é: {memoria}");
            //Aqui estamos retornando a propria CalculadoraCadeia (this)
            return this;
        }

        public int Resultado() {
            return memoria;
        }

    }

    class MetodosComRetorno {
        public static void Executar() {
            //Exemplo 1
            var calculadoraComum = new CalculadoraComum();
            Console.WriteLine($"O valor da Soma da Calculdora de 8 + 8 = {calculadoraComum.Somar(8, 8)}");

            //Exemplo 2
            var calculadoraCadeia = new CalculadoraCadeia();
            //Métodos encadeados
            calculadoraCadeia.Somar(200).Multiplicar(2).Imprimir().Limpar().Somar(3).Imprimir();
        }
    }
}
