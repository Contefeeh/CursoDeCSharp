using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresRelacionais {
        public static void Executar() {
            //double nota = 6.0;
            Console.WriteLine("Digite sua nota: ");
            double.TryParse(Console.ReadLine(),out double nota);
            double notaDeCorte = 7.0;

            Console.WriteLine($"Nota Invalida?(Nota maior que 10):  { nota > 10.0}.");
            Console.WriteLine($"Nota Invalida?(Nota menor que 0): {nota < 0.0}.");
            Console.WriteLine($"Perfeito?(Nota igual a 10): {nota == 10.0}");
            Console.WriteLine($"Tem como melhorar?(Nota diferente de 10?): {nota != 10.0} ");
            Console.WriteLine($"Passou por média?(Nota maior ou igual a nota de corte?: {nota >= notaDeCorte}");
            Console.WriteLine($"Recuperação(Nota menor que a nota de corte?): {nota < notaDeCorte}");
            Console.WriteLine($"Reprovado(Nota menor que 3.0?): {nota < 3.0}");

        }
    }
}
