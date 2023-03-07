using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.API {
    class ExemploTimeSpan {
        public static void Executar() {
            var intervalo = new TimeSpan(days: 10, hours: 30, minutes: 55, seconds: 03); 
            Console.WriteLine(intervalo);

            Console.WriteLine("Minutos: " + intervalo.Minutes);
            Console.WriteLine("Intervalo em Minutos: " + intervalo.TotalMinutes);

            var largada = DateTime.Now;
            var chegada = DateTime.Now.AddMinutes(15);

            var tempo = chegada - largada;

            Console.WriteLine($"Largada: {largada}, chegada {chegada} e o tempo: {tempo}. O tipo da " +
                $"variavel tempo é {tempo.GetType()}.");

            //Isso não adiciona ao intervalo original, é apenas uma cópia somada
            Console.WriteLine(intervalo.Add(TimeSpan.FromMinutes(8)));
            //Original
            Console.WriteLine(intervalo);
            //Abaixo exemplo mostra que a subtração foi aplicada a versão intervalo original
            Console.WriteLine(intervalo.Subtract(TimeSpan.FromMinutes(8)));

            //Ações do toString()
            //Dia:,Hora:,Minuto:,Segundo:
            Console.WriteLine("To String 1: " + intervalo.ToString("g"));//10:20:30:40
            Console.WriteLine("To String 2: " + intervalo.ToString("G"));//10:20:30:40,0000000
            Console.WriteLine("To String 3: " + intervalo.ToString("c"));//10.20:30:40

            //TimeSpan como parse de uma string para um TimeSpan
            //A partir disso vc pode fazer qualquer coisa relacionada a um TimeSpan convencional
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03").TotalMinutes);

        }
    }
}
