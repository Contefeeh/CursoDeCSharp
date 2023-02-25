using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesStack {
        public static void Executar() {
            //Não utiliza o Generic do System.Colletions
            var pilha = new Stack();
            //Push para adicionar na pilha
            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);//aceita float

            foreach ( var item in pilha) {
                Console.Write($"{item} ");
            }
            //O Pop saca o ultimo elemento adcionado na pilha 
            // /n pula uma linha
            //não use no loop
            Console.WriteLine($"\nPop: {pilha.Pop()}");
            //Verificando se o ultimo item foi sacado da pilha
            foreach (var item in pilha) {
                Console.Write($"{item} ");
            }
            //Não use no loop
            //Ele vai mostrar o valor que esta no topo da pilha(pronto para sair - POP), mas não vai remover
            Console.WriteLine($"\nPeek: {pilha.Peek()}");
            Console.WriteLine(pilha.Count);
        }
    }
}
