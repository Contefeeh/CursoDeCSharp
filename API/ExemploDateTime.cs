using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.API {
    class ExemploDateTime {
        public static void Executar() {
            var dateTime = new DateTime(year: 1987, month: 2, day: 26);

            //Acessos
            //Dia
            Console.WriteLine(dateTime.Day);
            //Mês
            Console.WriteLine(dateTime.Month);
            //Ano
            Console.WriteLine(dateTime.Year);

            //Data de hoje sem hora
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            //Data de hoje com hora
            var agora = DateTime.Now;
            Console.WriteLine("Agora: " + agora);
            //Acessando a hora de agora
            Console.WriteLine("Hora: " + agora.Hour);
            //Acessando os minutos
            Console.WriteLine("Minutos: " + agora.Minute);

            //Adicionar um dia
            var amanha = agora.AddDays(1);
            Console.WriteLine("Amanhã: " + amanha);

            //Tirar um dia
            var ontem = agora.AddDays(-1);
            Console.WriteLine("Ontem: " + ontem);

            //Formatações
            Console.WriteLine(agora.ToString("dd"));//Mostra somente o dia
            Console.WriteLine(agora.ToString("d"));//Mostra data completa
            Console.WriteLine(agora.ToString("D"));//Mostra data descritiva
            Console.WriteLine(agora.ToString("g"));//Dia mês e ano / hora e minuto
            Console.WriteLine(agora.ToString("G"));//Dia mês e ano / hora minuto e segundo
            Console.WriteLine(agora.ToString("dd/MM/yyyy HH:mm"));//Formatação descritiva
        }
    }
}