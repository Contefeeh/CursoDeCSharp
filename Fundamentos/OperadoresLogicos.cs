using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            //*Operadores Binários
            //And(E)
            var comprouTv50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine($"Comprou Tv 50? {comprouTv50}");
            //Or(Ou)
            var comprouSorvete = executouTrabalho1 || executouTrabalho2;
            Console.WriteLine($"Comprou sorvete? {comprouSorvete}");
            //Or exclusive(Ou exclusivo)
            var comprouTv32 = executouTrabalho1 ^ executouTrabalho2;
            Console.WriteLine($"Comprou Tv de 32? {comprouTv32}");

            //*Operador unário 
            //Negação lógica "!"
            Console.WriteLine($"Mais saudavel?(Não comprou o sorvete): {!comprouSorvete}");
        }
    }
}
