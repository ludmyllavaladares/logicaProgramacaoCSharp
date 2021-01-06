using System;
using System.Globalization;

namespace Area_do_circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, raio, pi = 3.14159;

            Console.WriteLine("Digite o valor do raio do círculo:");
            raio = double.Parse(Console.ReadLine());
            area = pi * (raio * raio);
            Console.WriteLine("A área = " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
