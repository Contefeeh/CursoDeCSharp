using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Dependente {
        public string Nome;
        public int Idade;
    }
    class ValorVsReferencia {
        public static void Executar() {
            //Atribuição por valor
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine("Numero: " + numero +" Copia Numero: "+ copiaNumero);

            numero++;
            Console.WriteLine("Novo Numero: " + numero + " Copia Numero: " + copiaNumero);

            //Atribuição por referencia
            Dependente dep = new Dependente { 
                Nome = "Beto",
                Idade = 21
            };

            Dependente copiaDep = dep;

            Console.WriteLine($"Nome Dep: {dep.Nome} - Copia Nome Dep: {copiaDep.Nome}");
            Console.WriteLine($"Idade Dep: {dep.Idade} - Copia Idade Dep: {copiaDep.Idade}");

            copiaDep.Nome = "Felipe";
            copiaDep.Idade = 36;

            Console.WriteLine($"Nome Dep: {dep.Nome} - Copia Nome Dep: {copiaDep.Nome}");
            Console.WriteLine($"Idade Dep: {dep.Idade} - Copia Idade Dep: {copiaDep.Idade}");


        }
    }
}
