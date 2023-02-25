using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class ExemploLambda {
        public static void Executar() {
            //Nessa action o sinal => "arrow" indica que a função vem logo após o parametro
            //Lambda é uma função anonima que armazena o resultado numa variavel
            //Action é uma função que não tem retorno "void"
            //Fecha com ponto e virgula
            //Pode receber parametros
            Action<string> algoNoConsole = (a) => {
                Console.WriteLine("Lambda com C#" + a);
            };

            algoNoConsole("!!!!");

            //Quando precisa de uma função que tenha retorno, use o Func
            //O arrow tem a mesma função que o exemplo de cima
            Func<int> jogarDado = () => {
                //Gera um numero aleatorio entre 1 e 6 (7 não entra)
                Random random = new Random();
                return random.Next(1, 7);
            };
            Console.WriteLine(jogarDado());

            //Essa função recebe um inteiro e retorna uma string
            Func<int, string> conversorHex = numero => numero.ToString("X");
            //O Codigo abaixo é a mesma coisa que o de cima
            //Func<int, string> conversorHex = (numero) => {
            //    return numero.ToString("X");
            //};
            Console.WriteLine(conversorHex(1234));

            //Nesse exemplo a função vai receber 3 inteiros e retornar uma string)
            //Como não colocamos corpo na função, ela implicidamente retorna a string do resultado
            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
                String.Format("{0:D2}/{1:D2}/{2:D4}",dia, mes, ano);

            Console.WriteLine(formatarData(1,1,1999));
        } 
    }
}
