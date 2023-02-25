using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class DelegateFuncAnonima {
        //Delegate
        delegate string StringOperacao(string s);

        public static void Executar() {
            StringOperacao inverter = delegate (string s) {
                //Um array de caracteres
                char[] charArray = s.ToCharArray();
                //Inverte os caracteres
                Array.Reverse(charArray);
                //Retorna a variavel com os caracteres invertidos
                return new string(charArray);
            };

            Console.WriteLine(inverter("atecubanos"));
        }
    }
}
