using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados {
    class Dynamics {
        public static void Executar() {
            //Variavel do tipo que aceita qualquer tipo
            //Inicialiaza como string
            dynamic meuObjeto = "Teste";
            //Recebe um inteiro
            meuObjeto = 3;
            //Recebe um encremento do inteiro
            meuObjeto++;
            //Retorna a soma do inteiro mais se encremento
            Console.WriteLine(meuObjeto);

            //Objeto que permite que vc insira objetos de maneira dinamica
            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Maria Julia";
            aluno.nota = 8.9;
            aluno.idade = 24;

            //acessando os objetos armazanados
            Console.WriteLine($"Nome: {aluno.nome} - Idade: {aluno.idade} - Nota: {aluno.nota}");
        }
    }
}
