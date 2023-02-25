using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    //Não se usa acentuação 
    //Notação Pascal Case
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia};

    public class Filme {
        public string Titulo;
        public Genero GeneroDoFilme;
    }

    class ExemploEnum {
        public static void Executar() {
            //É possivel fazer a conversão de um enum para um inteiro
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Tubarão";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;
            Console.WriteLine(filmeParaFamilia.Titulo + " - " + filmeParaFamilia.GeneroDoFilme);

        }
    }
}
