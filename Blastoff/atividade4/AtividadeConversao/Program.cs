using System;

namespace AtividadeConversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em ºC: ");
            decimal celsius = decimal.Parse(Console.ReadLine());

            decimal fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("A temperatura em ºF é: " + fahrenheit.ToString("#.#"));
            Console.ReadKey();
        }
    }
}
