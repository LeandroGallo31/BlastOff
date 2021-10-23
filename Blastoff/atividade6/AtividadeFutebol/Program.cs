using System;

namespace AtividadeFutebol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o horário inicial da partida: ");
            string inicialString = Console.ReadLine();

            double inicial = TimeSpan.Parse(inicialString).TotalMinutes;

            Console.WriteLine("Digite o horário final da partida: ");
            string finalString = Console.ReadLine();
            double final = TimeSpan.Parse(finalString).TotalMinutes;

            double duracao = final - inicial;

            double horas = duracao / 60;

            Console.WriteLine("A duração da partida em minutos foi: " + duracao.ToString("#.##"));
            Console.WriteLine("A duração da partida em horas foi: " + horas.ToString("#.##"));
        }
    }
}
