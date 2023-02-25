using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    //Modelo de escrita da classe Pascal Case
    class VariaveisEConstantes {
        public static void Executar() {
            //area da circunferencia
            double raio = 5.5;
            const double PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine($"Tipo double: A area da circuferencia do raio {raio} * PI (valor de PI = {PI}) é igual a {area}");

            //Modelo de escrita para variaveis Camel Case - Modelo Camelo
            bool estaChovendo = true;
            Console.WriteLine($"Tipo bool: Esta Chovendo? {estaChovendo}");

            //sbyte vai de -127 a 127
            sbyte pontos = -50;
            Console.WriteLine($"Tipo sbyte(Byte com sinal): Ponto negativo {pontos}");
            //byte vai de 0 a 256
            byte idade = 200;
            Console.WriteLine($"Tipo byte: Idade = {idade}");
            //short vai até cerca de 32.000
            short guitarra = 15350;
            Console.WriteLine($"Tipo short: Guitarra = {guitarra}");
            //int vai até cerca de -2.000.000 a 2.000.000
            int ferrari = 1350250;
            Console.WriteLine($"Tipo int: Ferrari = {ferrari}");
            //uint é o int sem sinal
            uint mansao = 2_000_458;//Underline faz o papel do ponto
            Console.WriteLine($"Tipo uint(Inteiro sem sinal): Valor da mansão = {mansao}");
            //long utilizado para valores maiores
            long brasil = 200000000;
            Console.WriteLine($"Tipo long: População Brasil = {brasil}");
            //ulong é o long sem sinal
            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine($"Tipo ulong(Long sem sinal): População Mundial = {populacaoMundial}");

            //Tipo float = valores reais
            float precoComputador = 1299.99f;
            Console.WriteLine($"Tipo float: Preço computador = {precoComputador}");

            //Tipo double = valores reais
            double valorDeMercadoApple = 1_000_000_000_000.00;
            Console.WriteLine($"Tipo double: Valor de mercado da Apple = {valorDeMercadoApple}");

            //Tipo decimal
            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine($"Tipo decimal: Distancia entre estrelas = {distanciaEntreEstrelas}");
            
            //Tipo char
            char letra = 'b';
            Console.WriteLine($"Tipo char: Letra = {letra}");

            //Tipo String
            string texto = "Seja bem vindo ao curso de CSharp";
            Console.WriteLine($"Tipo string: Texto = {texto}");
        }
    }
}
