using System;

namespace AtividadeMenorNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número B: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número C: ");
            int c = int.Parse(Console.ReadLine());

            int menorNumero = a;
            
            if(menorNumero > b )
            {
                menorNumero = b;
            }

            if (menorNumero > c )
            {
                menorNumero = c;   
            }

            Console.WriteLine("O menor número entre os  3 é: " + menorNumero);
            Console.ReadKey();
        }
    }
}
