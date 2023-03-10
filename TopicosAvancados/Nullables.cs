using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados {
    class Nullables {
        public static void Executar() {
            //Nullable permite que setemos um valor nulo em uma variavel
            //Pertence a biblioteca do Generic
            Nullable<int> num1 = null;
            //a interrogação demonstra que a variavel aceita nulo;
            int? num2 = null;

            //Se num1 tem valor
            if (num1.HasValue) {
                Console.WriteLine("Valor de num1: {0}", num1);
            } else {
                Console.WriteLine("A variavel não possui valor.");
            }

            //É possivel setar um valor padrao a uma variavel nullable usando duas interrogações
            int valor = num1 ?? 1000;
            Console.WriteLine(valor);

            bool? booleana = null;
            //Caso o valor de booleana seja null, ele pode trazer 
            //uma função sua ou um valor padrão(false)
            bool resultado = booleana.GetValueOrDefault();
            Console.WriteLine(resultado);

            try {
                //Para gerar um valor padrão e evitar erros
                int x = num1.GetValueOrDefault();
                int y = num2.GetValueOrDefault();
                Console.WriteLine(x + y);
            } catch (Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}
