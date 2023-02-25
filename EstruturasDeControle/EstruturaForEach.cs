using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaForEach {
        public static void Executar() {
            var palavra = ("Teste");
            var posicao = 1;

            foreach (var letra in palavra) {
                Console.WriteLine("A letra {0} é a posição numero {1} da palavra {2}.",letra,posicao,palavra);
                posicao++;
            }

            //Foreach percorrento uma lista
            var alunos = new string[] {"Felipe","João","Algelaine"};

            foreach (string aluno in alunos) {
                Console.WriteLine(aluno);
            }
        }
    }
}
