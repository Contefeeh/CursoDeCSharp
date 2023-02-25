using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    //Não permite que a classe seja instaciada
    sealed class SemFilho {
        public double ValorDaFortuna() {
            return 1_290_391.00;
        }
    }
    //Não permite herança
    //class Filho : SemFilho { 

    //}

    class Avo {
        public virtual bool HonrarNomeFamilia() {
            return true;
        }
    }

    class Pai : Avo {
        //Herdou do Avo subscreveu e selou. 
        public sealed override bool HonrarNomeFamilia() {
            return true;
        }    
    };

    class FilhoRebelde : Pai { 
        //No caso o override não vai funcionar, mas é possivel ocultar com o new

        //Funciona
        //public new bool HonrarNomeFamilia() {
        //    return false;
        //}

        //Não Funciona
        //public overide bool HonrarNomeFamilia() {
        //    return false;
        //}
    }
    class Sealed {
        public static void Executar() {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna().ToString("C2"));

            FilhoRebelde filhoRebelde = new FilhoRebelde();
            Console.WriteLine(filhoRebelde.HonrarNomeFamilia());
        }
    }
}
