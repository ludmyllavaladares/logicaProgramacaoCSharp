using System;

namespace Exponencial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro} {segundo} {terceiro}");
            } 
        }
    }
}
