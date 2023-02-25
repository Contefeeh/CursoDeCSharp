using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosNomeados {
        public static void Formatar(int dia, int mes, int ano) {
            //Estratégia de formatação de data
            Console.WriteLine("{0:D2}/{1:D2}/{2}",dia,mes,ano);
        }

        public static void Executar() {
            //Parametro nomeado
            Formatar(dia: 1, mes: 6, ano: 2023);
        }
    }
}
