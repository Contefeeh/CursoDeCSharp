using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Pessoa {
        //Atributo da classe deve ser PascalCase
        public string Nome;
        public int Idade;

        public string Apresentar() {
            return string.Format($"Ola me chamo {Nome} e tenho {Idade} de idade.");
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }

        public void Zerar() {
            Nome = "";
            Idade = 0;
        }
    }
}
