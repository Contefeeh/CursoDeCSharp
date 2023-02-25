using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public class Cliente {
        public string Nome;
        //Torna o valor imutavel e permite que ele seja inicializado depois
        //Caso vc use o const, a variavel precisa ser inicializada imediatamente
        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
        }

        public Cliente() { 
        
        }

        public string GetDataNascimento() {
            return String.Format("{0:D2}/{1:D2}/{2}", Nascimento.Day, 
                Nascimento.Month, Nascimento.Year);
        }
    }

    class ReadOnly {
        public static void Executar() {
            var novoCliente = new Cliente("Felipe",new DateTime(year:1987,day:26,month:2));
            Console.WriteLine(novoCliente.Nome + " " +novoCliente.GetDataNascimento());
        }
    }
}
