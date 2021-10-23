using System;
using System.Linq;

namespace AtividadeInterseccao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] listaA = new int[4] { 1, 2, 3, 4 };
            int[] listaB = new int[4] { 1, 2, 5, 8 };

            int[] intersec = new int[2];

            for (int i = 0; i < listaA.Length; i++)
            {
                var result = (from b in listaA
                            where listaA[i] == listaB[i]
                            select listaA[i]).FirstOrDefault();
                if(result > 0)
                {
                    intersec[i] = result;
                }
                
            }

            Console.WriteLine(String.Join("\n", intersec));
        }
    }
}
