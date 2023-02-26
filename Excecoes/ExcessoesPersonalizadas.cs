using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes {
    public class NegativoException : Exception{
        //construtor padrao
        public NegativoException() { }
        public NegativoException(string message) : base(message) { }
        //Essa exceção faz referênia a causa raiz da exceção. Exemplo:
        //Se o meu programa faz uma requisição e a rede esta off, ele quebra
        //Mas não por causa da requisição, mas por causa da rede
        public NegativoException(string message, Exception inner)
            : base(message, inner) { }
    }

    public class ImparException : Exception {
        public ImparException(string message) : base(message) { 
        
        }
    }

    class ExcessoesPersonalizadas {
        public static int PositivoPar() {
            Random random = new Random();
            int valor = random.Next(-30, 30);

            if (valor < 0) {
                //Se o valor for menor que 0, eu vou lançar uma nova exceção
                throw new NegativoException("Número Negativo ... :(");
            }

            if (valor % 2 == 1) {
                //Se o valor for impar eu lanço uma nova exceção
                throw new NegativoException("Número Impar ... :(");
            }

            return valor;
        }
        public static void Executar() {
            //Usaremos o Try porque o método pode gerar um erro
            try {
                Console.WriteLine(PositivoPar());
            } catch (NegativoException ex) {//Exceção negativa
                Console.WriteLine(ex.Message);
            } catch (ImparException ex) {//Exceção impar
                Console.WriteLine(ex.Message);
            } catch (Exception ex) {//Exceção genérica
                Console.WriteLine(ex.Message);
            } finally {//Finalização
                Console.WriteLine("Obrigado!");
            }
        }
    }
}
