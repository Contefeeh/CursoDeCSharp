using System;
//O Metodo List é acessado a partir do using Generic
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {

    public class Produto {

        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj) {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Nome, Preco);
        }
    }
    class ColecoesList {
        public static void Executar() {
            var livro = new Produto(nome: "Biblia", preco: 50.90);
            Console.WriteLine(livro.Nome + " " + livro.Preco);

            //Variavel carrinho recebe uma Lista do tipo Produto
            //A notação List é composta pelo maior que e menor que
            //Importante ter listas homogenias
            //O list é dinamico e não estatico como o array
            //O list aceita repetição de dados(duplicação)
            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var carro = new Produto(nome: "Fusca", preco: 12_000.00);
            carrinho.Add(carro);

            foreach (var item in carrinho) {
                Console.WriteLine(item.Nome + " - {0:C2}", item.Preco);
            }

            //Combo
            var combo = new List<Produto>() {
                new Produto(nome:"Livro da Xuxa",preco: 8.99),
                new Produto(nome:"Esponja de aço",preco: 0.99),
                new Produto(nome:"Banheira do Gugu",preco: 15.99)
            };

            //foreach (var item2 in combo) {
            //    carrinho.Add(item2);
            //}

            //Faz a mesma coisa que o ForEach acima
            carrinho.AddRange(combo);

            Console.WriteLine("Lista Fim:");
            //Removendo item de indice 3 (começa do 0)
            carrinho.RemoveAt(0);

            Console.WriteLine("Quantidade de itens no carrinho: " + carrinho.Count);
            foreach (var itemCarrinho in carrinho) {
                Console.Write(carrinho.IndexOf(itemCarrinho) + ": ");
                Console.WriteLine(itemCarrinho.Nome + " - {0:C2}", itemCarrinho.Preco);
            }
        }
    }
}
