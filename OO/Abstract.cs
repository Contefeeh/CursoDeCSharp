using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    //Classes Abstratas não podem ser instanciadas(Conceito abstrato não pode ser transformada em Objeto)
    //A abstratação significa que a classe não esta completamente acabada, e quem herdar deve finalizar a tarefa
    public abstract class Celular {
        //Pode haver métodos abstratos dentro de uma classe abstrata
        //O método abstrato não tem corpo
        //Qualquer classe concreta que herdar dessa classe abstrata, precisará implementar esse metodo
        public abstract string Assistente();

        //tambem é possivel ter um metodo concreto, com corpo
        public string Tocar(){
            return "Trim Trim Trim ...";
        }
    }

    public class Samsung : Celular {
        public override string Assistente() {
            return "Olá| Meu nome é Bixby!";
        }
    }

    public class Iphone : Celular {
        public override string Assistente() {
            return "Olá! Meu nome é Siri!";
        }
    }
    class Abstract {
        public static void Executar() {

            var celulares = new List<Celular> {
                new Iphone(),
                new Samsung()
            };

            foreach (var celular in celulares) {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
