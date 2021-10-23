using System;

namespace AtividadeDistancia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a distância percorrida: ");
            decimal distancia = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de combustível gasto: ");
            decimal combustivel = Decimal.Parse(Console.ReadLine());

            decimal consumo = (distancia / combustivel);

            Console.WriteLine("O consumo médio de combustível é: " + consumo.ToString("#.##"));
            Console.ReadKey();
        }
    }
}
