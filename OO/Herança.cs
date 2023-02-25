using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    public class Carro {
        //Eu quero que o atributo seja somente leitura e que seja passado por herança
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }

        //metodo protegido - comportamento
        protected int AlterarVelocidade(int delta) {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0) {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            } else {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        //Metodo publico
        //O Virtual permite que o metodo seja subscrito pela classe filha
        public virtual int Acelerar() {
            //Delta 5
            return AlterarVelocidade(5);
        }

        public int Frear() {
            return AlterarVelocidade(-5);
        }
    
    }

    public class Uno : Carro{
        //Como a classe mãe não tem um construtor padrão, precisamos cria-lo na classe filha
        //É assim que se constroi um, usando o base()
        public Uno() : base(200) { 
        
        }
    }

    public class Ferrari : Carro{ 
        public Ferrari() : base(350){
            
        }

        //Subscrever o método acelerar - método 1 usando o virtual na classe Mae
        public override int Acelerar() {
            return AlterarVelocidade(15);
        }

        //Metodo 2: usando o operador new para ocultar o metodo da classe mae
        //Se não ocultar, o método mae ficará aparecendo junto ao metodo filho
        public new int Frear() {
            return AlterarVelocidade(-15);
        }
    } 

    class Herança {
        public static void Executar() {
            Console.WriteLine("Uno ...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Ferrari carro2 = new Ferrari();
            Console.WriteLine("Ferrari ...");
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            //Exemplos de subscrever(override) e ocultar(new)
            Console.WriteLine("Ferrari com tipo Carro: Polimorfismo.");
            Carro carro3 = new Ferrari();//Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());            
            
            Console.WriteLine("Uno com tipo Carro: Polimorfismo.");
            carro3 = new Uno();//Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());


        }
    }
}
