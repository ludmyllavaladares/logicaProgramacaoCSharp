using System;
using System.Globalization;

namespace Intervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (numero < 0.0 || numero > 100.0)
            {
                Console.WriteLine("Fora do intervalo");
            }
            else if (numero <= 25.0)
            {
                Console.WriteLine("Está entre o intervalo [0, 25]");
            }
            else if (numero <= 50.0)
            {
                Console.WriteLine("Está entre o intervalo [25, 50]");
            }
            else if (numero <= 75.0)
            {
                Console.WriteLine("Está entre o intervalo [50, 75]");
            }
            else
            {
                Console.WriteLine("Está entre o intervalo [75 100]");
            }

        }
    }
}
