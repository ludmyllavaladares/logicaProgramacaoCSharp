using System;

namespace Par_ou_impar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número:");

            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Esse número é par");
            }
            else
            {
                Console.WriteLine("Esse número é ímpar");
            }

        }
    }
}
