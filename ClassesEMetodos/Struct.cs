using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    interface Ponto {
        //Função sem corpo
        //Se eu não colocar nenhum nivel de visibilidade, por padrão é publico
        void MoverNaDiagonal(int delta);
    }
    //Essa struct esta aderente a interface Ponto, através dessa escrita
    struct Coordenada : Ponto {
        public int X;
        public int Y;

        public Coordenada(int x, int y){
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta) {
            X += delta;
            Y += delta;
        }
    }

    class ExemploStruct {
        public static void Executar() {
            //Não precisa instanciar a classe na struct
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 3;

            Console.WriteLine("Coordenada Inicial X: {0} e Coordenada Inicial Y: {1}",coordenadaInicial.X, coordenadaInicial.Y);

            //Mas tambem é possivel instanciar
            var coordenadaFinal = new Coordenada(x: 5, y: 10);
            coordenadaFinal.MoverNaDiagonal(delta: 10);
            Console.WriteLine("Cordenada Final X: {0} e Coordenada Final Y:{1}",coordenadaFinal.X,coordenadaFinal.Y);
        }
    }
}
