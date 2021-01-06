using System;
using System.Globalization;


namespace Areas_formas_geometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            float A, B, C, ATrianguloRet, ACirculo, ATrapezio, AQuadrado, ARetangulo;
            double pi = 3.14159;

            Console.WriteLine("Digite três valores:");
            A = float.Parse(Console.ReadLine());
            B = float.Parse(Console.ReadLine());
            C = float.Parse(Console.ReadLine());

            ATrianguloRet = A * C / 2;
            ACirculo = (float) pi * C * C;
            ATrapezio = (A + B) * C / 2;
            AQuadrado = B * B;
            ARetangulo = A * B;

            Console.WriteLine("TRIÂNGULO: " + ATrianguloRet.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CÍRCULO: " + ACirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPÉZIO: " + ATrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + AQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETÂNGULO: " + ARetangulo.ToString("F3", CultureInfo.InvariantCulture));



        }
    }
}
