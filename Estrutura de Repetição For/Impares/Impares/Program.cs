using System;

namespace Impares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
