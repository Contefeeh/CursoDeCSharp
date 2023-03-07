using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CursoCSharp.TopicosAvancados {
    public class Aluno {
        public string Nome;
        public int Idade;
        public double Nota;
    }

    class LINQ1 {
        public static void Executar() {
            //Lista de alunos
            var alunos = new List<Aluno> {
                new Aluno() { Nome = "Pedro", Idade = 24, Nota = 8.0 },
                new Aluno() { Nome = "André", Idade = 21, Nota = 4.3 },
                new Aluno() { Nome = "Ana", Idade = 25, Nota = 9.5 },
                new Aluno() { Nome = "Jorge", Idade = 20, Nota = 8.5 },
                new Aluno() { Nome = "Ana", Idade = 21, Nota = 7.7 },
                new Aluno() { Nome = "Julia", Idade = 22, Nota = 7.5 },
                new Aluno() { Nome = "Marcio", Idade = 18, Nota = 6.8 }
            };

            Console.WriteLine("==Aprovados===============================");

            //Passando uma função como parametro para uma função Where
            //Nessa função eu quero os alunos que tiveram notas maiores que 7
            //E tambem estou ordenando por Nota, da maior pra menor através do simbolo - antes do a
            var aprovados = alunos.Where(a => a.Nota >= 7).OrderBy(a => -a.Nota);
            foreach (var aluno in aprovados) {
                Console.WriteLine(aluno.Nome + " : " + aluno.Nota);
            }

            Console.WriteLine("\n==Chamada=================================");
            //Na linha abaixo a variavel chamada recebe o resultado da tranformação do
            //objeto alunos no objeto chamada que só possue o nome
            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
            foreach (var aluno in chamada) {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n==Aprovados (por Idade)====================");
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;

            foreach (var aluno in alunosAprovados) {
                Console.WriteLine(aluno);
            }
            
        }
    }
}
