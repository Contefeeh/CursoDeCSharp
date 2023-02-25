using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadorTernario {
        public static void Executar(){
            var nota = 7.0;
            bool bomCorpotamento = false;
            //Expressão ? Resultado 1 : Resultado 2
            var resultado = nota >= 7.0 ? "Aprovado" : "Reprovado";
            Console.WriteLine("Status do aluno: " + resultado);

            //Exemplo 2
            string resultado2 = nota >= 7.0 && bomCorpotamento ? "Aluno top" : resultado;
            Console.WriteLine("Status Geral do aluno: " + resultado2);
        }
    }
}
