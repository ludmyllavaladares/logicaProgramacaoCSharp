using System;

namespace Positivo_ou_negativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.WriteLine("Digite um número:");

            x = int.Parse(Console.ReadLine());

            if (x < 0)
            {
                Console.WriteLine("Esse número é negativo");
            }
            else
            {
                Console.WriteLine("Esse número é positivo");   
            }
        }
    }
}
