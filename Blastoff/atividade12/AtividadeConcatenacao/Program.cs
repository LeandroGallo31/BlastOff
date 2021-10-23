using System;
using System.Linq;

namespace AtividadeConcatenacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] listaA = { 1, 2, 3, 4 };
            int[] listaB = { 1, 2, 5, 8 };
            listaA = listaA.Concat(listaB).ToArray();
            foreach (var numero in listaA)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
