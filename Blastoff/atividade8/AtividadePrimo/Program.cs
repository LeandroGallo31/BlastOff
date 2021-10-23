using System;

namespace AtividadePrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int n1 = int.Parse(Console.ReadLine());

            string resultado = "";

            for (int i = 2; i < n1; i++)
            {
                if (n1 % i == 0)
                {
                    resultado = "O número não é primo.";
                }
                else
                {
                    resultado = "O número é primo.";
                }
            }

            Console.WriteLine(resultado);   
        }
    }
}
