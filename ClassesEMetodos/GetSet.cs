using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class Moto {
        //Por padrão, se um atributo não tem especificação ele é private
        private string Marca;
        private string Modelo;
        private uint Cilindrada;
        //Construtor Padrão
        public Moto() { 
        
        }
        //Construtor da Classe
        public Moto(string marca, string modelo, uint cilindrada) {

            //estratégia 1 - para validar os valores de entrada dos atributos
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);

        }
        //Get Set Marca
        public string GetMarca() {
            return Marca;
        }

        public void SetMarca(string marca) {
            Marca = marca;
        }
        //Get Set Modelo
        public string GetModelo() {
            return Modelo;
        }

        public void SetModelo(string modelo) {
            Modelo = modelo;
        }
        //Get Set Cilindrada
        public uint GetCilindrada() {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada) {
            //Estratégia 1 - para validar os valores de entrada dos atributos
            //if (cilindrada < 0) {
            //    cilindrada = 0;
            //} else {
            //    Cilindrada = cilindrada;
            //}

            //Estratégia 2 - para validar os valores de entrada dos atributos
            //Cilindrada = Math.Abs(cilindrada);

            //Estratégia 3 - para validar os valores de entrada dos atributos
            //usar o uint - valor inteiro positivo
            Cilindrada = cilindrada;
        }
    }

    class GetSet {
        public static void Executar() {
            //Enviando dados via construtor
            var moto1 = new Moto("Kawazaki", "Ninja ZX-6R", 636);
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            //Enviando dados via método set
            moto2.SetMarca("Honda");
            moto2.SetModelo("Titan");
            moto2.SetCilindrada(150);
            Console.WriteLine(moto2.GetMarca());
            Console.WriteLine(moto2.GetModelo());
            Console.WriteLine(moto2.GetCilindrada());
        }
    }
}
