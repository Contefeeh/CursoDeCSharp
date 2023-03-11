using System;
using System.Collections.Generic;
using System.Text;
using CursoCSharp.ClassesEMetodos;

namespace CursoCSharp.TopicosAvancados {

    public class Caixa<T>{
        //Tipo T privado
        T valorPrivado;
        //Criou um atributo do tipo coisa e ja criou o metodo Get e Set
        //Ele recebe o valor atribuido e e seta no lugar do método generico de T
        public T Coisa { get; set; }

        //Construtor de coisa
        public Caixa(T coisa) {
            Coisa = coisa;
            valorPrivado = coisa;
        }

        //Recebe um T e retorna um T
        public T metodoGenerico(T valor) {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }

        public T GetValor() {
            return valorPrivado;
        }
    }

    //Herda da classe generica Caixa, passando int 
    //como parametro e implementando um construtor
    class CaixaInt : Caixa<int> {
        //No momentoda da herança quem utilizar tera de passar um valor inteiro. Inicializado com 0(base)
        public CaixaInt() : base(0) { 
        
        }
    }

    //Usando a classe Produto de classes e Métodos para exemplo do dinamismo da classe generica
    class CaixaProduto : Caixa<Produto> {
        //Passo para o construtor um novo Produto
        public CaixaProduto() : base(new Produto) { 
        
        }
    }

    class Genericos {
        public static void Executar() {
            //O objeto caixa1 recebe uma nova caixa passando 
            //parametro inteiro e o valor 1000 no corpo
            var caixa1 = new Caixa<int>(1000);
            Console.WriteLine(caixa1.metodoGenerico(1000));
            //QUal o tipo atual de Coisa?
            Console.WriteLine("Tipo Coisa: " + caixa1.Coisa.GetType());

            //Caixa recebendo string como parametro para T
            var caixa2 = new Caixa<string>("Construtor");
            //Ou o método retorna o valor do construtor ou a resposta generica
            Console.WriteLine(caixa2.metodoGenerico("Resposta Genérica."));
            Console.WriteLine(caixa2.Coisa.GetType());

            //Iniacializando uma variavel do tipo CaixaProduto
            CaixaProduto caixa3 = new CaixaProduto();
            Console.WriteLine(caixa3.Coisa.GetType().Name);
        }
    }
}
