using System;
using Encapsulamento;

namespace CursoCSharp.OO {

    public class FilhoNaoReconhecido : SubCelebridade {
        //O operador new esta escondendo o metodo MeusAcessos da classe Mae(SubCelebridade)
        public new void MeusAcessos() {
            Console.WriteLine("Filho não reconhecido ...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            //Não tm acesso a NumeroDeCelular
            Console.WriteLine(JeitoDeFalar);
            //SegredoFamiliar não tem acesso
            //UsaMuitoPhotoshop tambem não pode ser acessado
        }
    }

    public class AmigoDistante{
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos() {
            Console.WriteLine("Amigo Distante ...");
            Console.WriteLine(amiga.InfoPublica);
            //CorDosOlhos não tem acesso
            //Numero do celular não tem acesso
            //Não tem acesso ao JeitoDeFalar
            //Também não tem acesso a SegredoFamiliar
            //Tambem não tem acesso a UsaMuitoPhotoshop
        }
    }

    class Encapsulamento {
        public static void Executar() {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}
