using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    class CarroOpcional {
        double desconto = 0.1;

        string nome;

        public string Nome {
            get {
                return "Opcional: " + nome;
            }
            set {
                nome = value;
            }
        }
        //Propriedade autoimplementada
        public double Preco{ get; set; }

        //Somente leitura
        public double PrecoComDesconto {
            get => Preco - (desconto*Preco); //Lambda

            //Equivale ao escrito acima
            //get {
            //    return Preco - (desconto * Preco);
            //}
        }

        public CarroOpcional(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public CarroOpcional() { 
        
        }
    }

    class Props {
        public static void Executar() {
            var opcional1 = new CarroOpcional(nome: "Ar condicionado",1_000);
            Console.WriteLine( opcional1.Nome + " Preço: " + 
                opcional1.Preco + " Preço com desconto: " + opcional1.PrecoComDesconto);

            var opcional2 = new CarroOpcional();
            opcional2.Nome = "Direção elétrica";
            opcional2.Preco = 2_000;

            Console.WriteLine( opcional2.Nome + " Preço: " +
                opcional2.Preco + " Preço com desconto: " + opcional2.PrecoComDesconto);

        }
    }
}
