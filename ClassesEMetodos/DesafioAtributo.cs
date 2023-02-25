using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class DesafioAtributo {

        int a = 10;

        public static void Executar() {
            //acesse a variavel 'a' dentro do método Executar!
            //Crie uma instancia da classe desafio atributo e depois acesse através da variavel instanciada
            DesafioAtributo desafio = new DesafioAtributo();
            Console.WriteLine(desafio.a);
        }
    }
}
