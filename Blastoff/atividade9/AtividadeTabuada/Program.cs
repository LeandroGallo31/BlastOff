using System;

namespace AtividadeTabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            int n1 = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n1; i++)
            {
                int resultado = n1 * i;
                Console.WriteLine(resultado);   
            }
        }
    }
}
