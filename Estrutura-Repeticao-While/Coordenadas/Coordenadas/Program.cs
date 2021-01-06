using System;

namespace Coordenadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as coordenadas X e y:");


            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            while (X != 0 && Y != 0)
            {
 
                if (X > 0 && Y > 0)
                {
                    Console.WriteLine("Q1");
                }
                else if (X > 0 && Y < 0)
                {
                    Console.WriteLine("Q4");
                }
                else if (X < 0 && Y < 0)
                {
                    Console.WriteLine("Q3");
                }
                else
                {
                    Console.WriteLine("Q2");
                }
                Console.WriteLine("Digite as coordenadas X e y:");

                 X = int.Parse(Console.ReadLine());
                 Y = int.Parse(Console.ReadLine());


            }

        }
    }
}
