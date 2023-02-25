using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class Array {
        public static void Executar() {
            //Array é homogenio e estatico, ou seja, uma vez criado ele sempre terá a mesma caracteristica
            //O Array é uma estrutura indexada
            //O Array só pode ser acessado através do indice
            string[] alunos = new string[5];
            alunos[0] = "Felipe";
            alunos[1] = "Andre";
            alunos[2] = "Luis";
            alunos[3] = "Joao";
            alunos[4] = "Alge";

            //foreach é excelente para lidar com arrays
            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = {5.0,6.2,9.0,7.3,9.7};

            //Via for
            //for (int i = 0;i < notas.Length ; i++) {
            //    somatorio += notas[i];
            //}

            //via foreach
            foreach (var nota in notas) {
                somatorio += nota;
                Console.WriteLine(nota);
            }
            Console.WriteLine("Quantidade de notas: " + notas.Length);
            Console.WriteLine("média: "+ somatorio/notas.Length);

            char[] letras = {'A','R','r','A','y'};
            string palavra = new string(letras);
            foreach (var letra in letras) {
                Console.WriteLine(letra);
            }
            Console.WriteLine(palavra);
        }
    }
}
