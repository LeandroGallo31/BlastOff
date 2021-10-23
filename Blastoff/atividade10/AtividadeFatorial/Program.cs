namespace AtividadeFatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int numero = int.Parse(Console.ReadLine());

            int fatorial = numero;
            for (int i = numero - 1; i >= 1; i--)
            {
               fatorial = fatorial * i;
            }
            Console.WriteLine("O Fatorial de " + numero + " é " + fatorial );
            Console.ReadLine();
        }
    }
}
