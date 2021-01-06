using System;
using System.Globalization;

namespace Divisao_em_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantos pares de número deseja digitar:");

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] pares = Console.ReadLine().Split(' ');
                double a = double.Parse(pares[0]);
                double b = double.Parse(pares[1]);

                if (b != 0)
                {
                    double divido = a / b;
                    Console.WriteLine("A divisão é = " + divido.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Divisão impossível");
                }

            }
        }
    }
}
