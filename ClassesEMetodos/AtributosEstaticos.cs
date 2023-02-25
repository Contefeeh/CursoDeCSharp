using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    class Produto {
        public string Nome;
        public double Preco;

        //Atributo do Objeto
        public double DescontoObjeto;

        //Atributo da classe
        public static double DescontoClasse;
        
        //Construtor
        public Produto(string nome, double preco, double desconto) {
            Nome = nome;
            Preco = preco;
            DescontoObjeto = desconto;
        }

        public Produto() { 
        
        }

        public double CalcularDesconto() {
            return Preco - Preco * DescontoObjeto;        
        }

        public double CalcularDescontoStatic() {
            return Preco - Preco * DescontoClasse;
        }
    }

    class AtributosEstaticos {
        public static void Executar() {
            //Forma via Construtor da classe
            var produto1 = new Produto("Caneta", 90.0, 0.1);

            Console.WriteLine($"Produto 1: {produto1.CalcularDesconto()}");

            //Forma via Construtor Padrão
            var produto2 = new Produto() {
                Nome = "Borracha",
                Preco = 100.0,
                DescontoObjeto = 0.1
            };

            Console.WriteLine($"Produto 2: {produto2.CalcularDesconto()}");

            //Acessando através da classe
            Produto.DescontoClasse = 0.5;
            Console.WriteLine($"Produto 1(90,00 50% da classe) exemplo static: {produto1.CalcularDescontoStatic()}");
            Console.WriteLine($"Produto 2(100,00 50% da classe) exemplo static: {produto2.CalcularDescontoStatic()}");
        }
    }
}

