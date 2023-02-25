using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    public class Animal {
        public string Nome { get; set; }

        public Animal(string nome) {
            Nome = nome;
        }
    }

    public class Cachorro : Animal {
        public double Altura { get; set; }
        //Construtor utiliza o construtor da classe Pai para poder setar o nome através do (base)
        public Cachorro(string nome) : base(nome){
            Console.WriteLine($"Cachorro {nome} Inicializado!");
        }
        //Construtor utiliza o construtor da própria classe para setar a altura
        public Cachorro(string nome, double altura) : this(nome) {
            Altura = altura;
        }
        //subscrevendo o método ToString
        public override string ToString() {
            return $"O {Nome} tem {Altura} centimentros de altura";
        }
    }

    class ConstrutorThis {
        public static void Executar() { 
            var spike = new Cachorro("Spike");
            var max = new Cachorro("Max", 40.0);
            Console.WriteLine(spike);
            Console.WriteLine(max.ToString());
        }
    }
}
