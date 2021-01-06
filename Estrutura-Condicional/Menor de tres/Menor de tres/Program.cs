using System;

namespace Menor_de_tres
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Digite três números:");

            string[] vet = Console.ReadLine().Split(' ');

            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            c = int.Parse(vet[2]);

            if (a < b && a < c)
            {
                Console.WriteLine("O menor é: "+ a);
            }
            else if (b < c) 
            {
                Console.WriteLine("O menor é: "+ b);
            }
            else
            {
                Console.WriteLine("O menor é: "+ c);
            }

        }
    }
}
