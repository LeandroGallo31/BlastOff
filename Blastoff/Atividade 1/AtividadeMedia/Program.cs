using System;

namespace AtividadeMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {

			int soma, resultado;

			Console.WriteLine("Digite a idade I: ");
			int I = int.Parse(Console.ReadLine());

			Console.WriteLine("Digite a idade J: ");
			int J = int.Parse(Console.ReadLine());

			Console.WriteLine("Digite a idade K: ");
			int K = int.Parse(Console.ReadLine());

			Console.WriteLine("Digite a idade X: ");
			int X = int.Parse(Console.ReadLine());

			Console.WriteLine("Digite a idade Y: ");
			int Y = int.Parse(Console.ReadLine());

			soma = (I + J + K + X + Y);

			resultado = soma / 5;

			Console.WriteLine("A média das idades é: " +  resultado);
		}
    }
}
