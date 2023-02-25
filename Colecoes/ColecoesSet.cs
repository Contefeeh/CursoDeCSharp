using System;
//O Metodo List é acessado a partir do using Generic
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {

    class ColecoesSet {
        public static void Executar() {
            var livro = new Produto(nome:"Biblia",preco:50.90);
            Console.WriteLine(livro.Nome + " " + livro.Preco);

            //Importante ter listas homogenias
            //HashSet não é indexado
            //Não aceita duplicação
            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var carro = new Produto(nome: "Fusca",preco: 12_000.00);
            carrinho.Add(carro);

            foreach (var item in carrinho) {
                Console.WriteLine(item.Nome + " - {0:C2}", item.Preco);
            }

            //Combo
            var combo = new HashSet<Produto>() {
                new Produto(nome:"Livro da Xuxa",preco: 8.99),
                new Produto(nome:"Esponja de aço",preco: 0.99),
                new Produto(nome:"Banheira do Gugu",preco: 15.99)
            };

            //Entra no lugar do AddRange() do list
            carrinho.UnionWith(combo);

            Console.WriteLine("Lista Fim:");
            Console.WriteLine("Quantidade de itens no carrinho: " + carrinho.Count);
            foreach (var itemCarrinho in carrinho) {
                Console.WriteLine(itemCarrinho.Nome + " - {0:C2}", itemCarrinho.Preco);
            }
        }
    }
}
