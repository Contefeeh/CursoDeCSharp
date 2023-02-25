using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Inferencia {
        public static void Executar() {
            //Variaveis do tipo que de aferição do Csharp.
            //Ele é responsavel por entender o tipo e definir
            //Não pode ser trocado de tipo posteriormente
            //Deve ser inicializada imediatamente a sua criação
            var nome = "Felipe";
            var idade = 36;
            Console.WriteLine($"Tipo var: Variavel nome e a variavel idade são do tipo var (inferência do CSharp). " +
                $"Nome = {nome} e idade = {idade}");

        }
    }
}
