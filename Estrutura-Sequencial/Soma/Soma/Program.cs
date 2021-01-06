using System;

namespace Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, soma;
            Console.WriteLine("Digite dois números inteiros:");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
           
            soma = A + B;
            Console.WriteLine("A soma é: " + soma);
        }
    }
}
