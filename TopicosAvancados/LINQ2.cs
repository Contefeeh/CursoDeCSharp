using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados {
    class LINQ2 {
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

            //Esse método retorna um erro se não der match na busca
            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine(pedro.Nome + " " + pedro.Nota);

            //Esse não da erro. Ele retorna o valor padrão de um objeto que é nulo
            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));

            if(fulano == null) {
                Console.WriteLine("Aluno inexistente.");
            }
            else{
                Console.WriteLine($"{fulano.Nome} {fulano.Nota}");
            }

            //A primeira Ana que ele encontrar ele vai retornar.
            //Essa função retorna um erro se não encontrar
            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine($"{ana.Nome} {ana.Nota}");

            //Essa função retorna nulo se não encontrar
            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("Sicrano"));

            //Tratamos com if
            if (sicrano == null) {
                Console.WriteLine("Aluno não encontrado");
            } else {
                Console.WriteLine(sicrano.Nome + " " + sicrano.Nota);
            }

            //Tambem podemos pegar o ultimo
            var outraAna = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine($"Outra Ana: {outraAna.Nome} {outraAna.Nota}");

            //Função util para pagina de lista
            //Não função abaixo ele pede para pegar 3 alunos e pulando 1
            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var item in exemploSkip) {
                Console.WriteLine(item.Nome);
            }

            //Maior nota
            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            //Menor nota
            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            //Soma das notas
            var somatoriaNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine("Somatoria: " + somatoriaNotas);

            //Média
            var mediaNotas = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine("Média Turma: " + mediaNotas);

            //Média filtrada por aprovados
            var mediaAprovados = alunos.Where(a => a.Nota >= 7.0).Average(aluno => aluno.Nota);
            Console.WriteLine("Média dos aprovados: " + mediaAprovados);

        }
    }
}
