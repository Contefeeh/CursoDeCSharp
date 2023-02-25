using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class Igualdade {
        public static void Executar() {
            var p1 = new Produto("Tv Philco",1_945.80);
            var p2 = new Produto("Tv Philco",1_945.80);
            var p3 = p2;

            //p1 e p2 não são iguais, pois não utilizam o mesmo espaço de memoria
            Console.WriteLine(p1 == p2);
            //Quando criamos um objeto através de outro, ai sim serão iguais
            Console.WriteLine(p2 == p3);
            //Para comparação da igualdade do conteudo do objeto usamos o Equals
            //Para que ele funcione como comparador do objeto é necessario subscrever o método Equals(override) na classe Produto
            Console.WriteLine(p1.Equals(p2));
        }
    }
}
