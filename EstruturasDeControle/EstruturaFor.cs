using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaFor {
        public static void Executar() {
            //Exemplo Simples - a Variavel i só é visivel dentro do bloco do for
            //for (int i = 1; i <= 10; i++) {
            //    Console.WriteLine("Teste " + i);
            //}

            double somatorio = 0;
            string entradaUsuario;

            Console.WriteLine("Informe o tamanho da turma: ");
            entradaUsuario = Console.ReadLine();
            int.TryParse(entradaUsuario, out int tamanhoTurma);

            for (int i = 1;i <= tamanhoTurma;i++) {
                Console.Write("Informe a nota do aluno {0}: ", i);
                entradaUsuario = Console.ReadLine();
                double.TryParse(entradaUsuario, out double notaAtual);
                //Mesma coisa que somatorio = somatorio + notaAtual
                somatorio += notaAtual;
            }

            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("Tamanho da Turma: {0} | Média da Turma: {1}", tamanhoTurma,media);
        }
    }
}
