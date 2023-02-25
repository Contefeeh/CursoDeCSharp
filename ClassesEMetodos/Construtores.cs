using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        //Construtor que recebe parametro
        //Caso o parametro tenha o mesmo nome do atributo, utilize "this"
        public Carro(string modelo, string fabricante, int ano) {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }

        public Carro() { 
        
        }
    }

    class Construtores {
        public static void Executar() {

            //Construtor Padrão não recebe parametro e retorna uma instanica da classe
            var carro1 = new Carro();
            carro1.Modelo = "Fusca";
            carro1.Fabricante = "VW";
            carro1.Ano = 1977;
            Console.WriteLine($"Carro 1: {carro1.Fabricante} - {carro1.Modelo} - {carro1.Ano}");

            //Construtor de Classe personalizada
            var carro2 = new Carro("Savero", "VW", 1980);
            Console.WriteLine($"Carro 2: {carro2.Fabricante} - {carro2.Modelo} - {carro2.Ano}");

            //Terceiro Exemplo para setar os dados num construtor padrão
            var carro3 = new Carro() {
                Modelo = "Variante",
                Fabricante = "VW",
                Ano = 1966
            };
            Console.WriteLine($"Carro 3: { carro3.Fabricante} - { carro3.Modelo} - {carro3.Ano}");
        }
    }
}
