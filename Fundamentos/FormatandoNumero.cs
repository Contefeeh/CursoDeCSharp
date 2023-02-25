using System;
using System.Globalization;//Informações de culturas de paises

namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine("Valor base: " + valor);
            Console.WriteLine(valor.ToString("F1"));//1 casa decimal
            Console.WriteLine(valor.ToString("C"));//Valor monetário
            Console.WriteLine(valor.ToString("P"));//Valor percentual
            Console.WriteLine(valor.ToString("#.##"));//2 casas decimais

            CultureInfo culturaBrasileira = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C2",culturaBrasileira));//Coloca o cifrão e define a casa decimal em duas casas

            CultureInfo culturaAmericana = new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", culturaAmericana));//Coloca o dólar e define a casa decimal em zero casas

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));//Completa com zeros até que a cadeia de caracteres tenha 10 digitos
        }
    }
}
