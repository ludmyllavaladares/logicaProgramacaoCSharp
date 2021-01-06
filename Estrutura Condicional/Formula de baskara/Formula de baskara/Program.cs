using System;
using System.Globalization;

namespace Formula_de_baskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;

            Console.WriteLine("Digite três valores:");

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - (4 * a * c);

            if ((delta < 0.0) || (a == 0.0)) {
            
                Console.WriteLine("Impossível calcular");
            }

            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

                Console.WriteLine("X1 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("X2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));
            }

        }
    }
}
