using System;

namespace AtividadePares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quantos numeros tem na lista: ");
            int contador = int.Parse(Console.ReadLine());

            int[] valores;
            valores = new int[contador];

            for (int i = 0; i < contador; i++)
            { 
                Console.WriteLine("Digite os valores \n");
                valores[i] = int.Parse(Console.ReadLine());
            }

            int[] pares;
            pares = new int[contador];

            for (int i = 0; i < contador; i++)
            {
                
                if(valores[i] % 2 == 0)
                {
                    pares[i] = valores[i];
                }
            }
            Console.WriteLine(String.Join("\n", pares));
        }
    }
}
