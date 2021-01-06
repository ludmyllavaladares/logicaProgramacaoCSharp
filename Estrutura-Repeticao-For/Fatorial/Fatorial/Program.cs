using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para saber seu fatorial:");

            int n = int.Parse(Console.ReadLine());

            int fatorial = 1;
            for (int i = 1; i <= n; i++)
            {
                fatorial = fatorial * i;
            }

            Console.WriteLine("O fatorial de " + n + " é: " + fatorial);

        }
    }
}

