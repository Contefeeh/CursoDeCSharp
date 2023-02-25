using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes {

    public class Conta {
        double Saldo;

        public Conta(double saldo){
            Saldo = saldo;
        }

        public void Sacar(double valor) {
            if (valor > Saldo) {
                //Lançando uma exceção criada
                //trow lança uma nova(new) exceção
                //ArgumentException é filha da Exception
                throw new ArgumentException("Saldo insuficiente.");
            }
            Saldo -= valor;
        }
    }
    class PrimeiroExcecao {
        public static void Executar() {
            var conta = new Conta(1_223.45);

            //Sempre que você for usar um método que pode gerar um erro, 
            //é bom usar o Try
            //O catch esta vinculado à exceção criada no método ArgumentException
            //O finally sempre sera executado
            //Exception é o tipo mais generico das exceções
            try {
                conta.Sacar(1_600.00);
                Console.WriteLine("Retire Seu dinheiro.");
            } catch (Exception ex) {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine("Ocorreu um problema: " + ex.Message);
            } finally {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}
