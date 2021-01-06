using System;

namespace Diferenca_de_produto
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, diferenca;
            Console.WriteLine("Digite quatro números inteiros:");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            diferenca = (A * B) - (C * D);

            Console.WriteLine("A diferença dos produtos = " + diferenca);



        }
    }
}
