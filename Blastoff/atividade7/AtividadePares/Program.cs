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
                Console.WriteLine("Digite os valores");
                valores[i] = int.Parse(Console.ReadLine());
            }

            int[] pares;
            int length = 1;
            pares = new int[length];
            

            for (int i = 0; i < contador; i++)
            {
                int j = 0;
                if(valores[i] % 2 == 0)
                {
                    pares[j] = valores[i];
                    j++;
                    length++;
                }
            }
            Console.WriteLine("Os valores pares são: " + pares.ToString());
        }
    }
}
