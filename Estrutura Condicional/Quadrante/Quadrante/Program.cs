using System;
using System.Globalization;


namespace Quadrante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números");

            double X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (X > 0.0 && Y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (X > 0.0 && Y < 0.0)
            {
                Console.WriteLine("Q4");
            }
            else if (X < 0.0 && Y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else if (X < 0.0 && Y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else
            {
                Console.WriteLine("origem");
            }



        }
    }
}
