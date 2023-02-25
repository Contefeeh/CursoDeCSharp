using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            //Notação ponto
            var saudacao = "Olá".ToUpper().Insert(3," Teste ").Replace(" Teste "," Mundo!").ToUpper();
            Console.WriteLine(saudacao);
            //Objetos nulos ou vazias podem gerar erros ao terem a notação ponto inserida
            //Exemplo
            string valorImportante = null;
            //Console.WriteLine(valorImportante.Length);
            //Para uma navegação segura use a ?
            Console.WriteLine($"Valor nulo testado com a interrogação antes da notação" +
                $"ponto: Valor = '{valorImportante?.Length}'");
        }
    }
}
