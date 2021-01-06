using System;
using System.Globalization;

namespace Media_ponderada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite quantos números deseja avaliar:");

            double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double y = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double z = double.Parse(valores[2], CultureInfo.InvariantCulture);

                double media = (x * 2.0 + y * 3.0 + z * 5.0) / 10.0;

                Console.WriteLine("A média é = " + media.ToString("F1", CultureInfo.InvariantCulture));

            }
        }
    }
}
