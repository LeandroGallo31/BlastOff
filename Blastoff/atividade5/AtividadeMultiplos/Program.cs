using System;

namespace AtividadeMultiplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            if(n1 <= 0 || n2 <= 0)
            {
                Console.WriteLine("Os números devem ser maiores do que 0");
                return;
            }

            int resultado = 0;
            if(n1 >= n2)
            {
                resultado = n1 % n2;
            }
            else if( n2 > n1)
            {
                resultado = n2 % n1;
            }

            if( resultado == 0)
            {
                Console.WriteLine("Os números são multiplos.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Os números não são multiplos.");
                Console.ReadKey();
            }

        }
    }
}
