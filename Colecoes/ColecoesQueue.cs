using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesQueue {
        public static void Executar() {
            //Instaciado novo objeto do tipo queue (Fila)
            //Esse Queue utiliza Generics
            var fila = new Queue<string>();

            //Para inserir dados na fila
            fila.Enqueue("Felipe");
            fila.Enqueue("João");
            fila.Enqueue("Alge");

            //Exibe o primeiro elemento da fila para sair, mas não remove
            Console.WriteLine("Próximo: " + fila.Peek());
            //Para saber a quantidade de elementos da fila
            Console.WriteLine("Quantidade: " + fila.Count);

            //para tirar elemento da fila
            fila.Dequeue();

            Console.WriteLine("Próximo: " + fila.Peek());
            Console.WriteLine("Quantidade: " + fila.Count);
            //Varrendo uma lista 
            Console.WriteLine("------------------------");
            Console.WriteLine("Demais pessoas da Fila: ");
            foreach (var pessoa in fila) {
                Console.WriteLine(pessoa);
            }

            //nova fila
            //Esse Queue não utiliza generics
            var salada = new Queue();
            salada.Enqueue(3.1212);
            salada.Enqueue("Cachorro");
            salada.Enqueue(true);

            Console.WriteLine("Salada contem Cachorro? " + salada.Contains("Cachorro"));
        }
    }
}
