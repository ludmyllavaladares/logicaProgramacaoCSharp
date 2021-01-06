using System;
using System.Globalization;

namespace Imposto_sobre_o_salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor do seu salário");

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto;

            if (salario <= 2000.00)
            {
                imposto = 0.0;
            }
            else if (salario <= 3000.00)
            {
                imposto = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.00)
            {
                imposto = (salario - 3000.00) * 0.18 + 1000.00 * 0.08;
            }
            else
            {
                imposto = (salario - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08;
            }
            if (imposto == 0)
            {
                Console.WriteLine("Isento de imposto");
            }
            else
            {
                Console.WriteLine("O valor do imposto a pagar será de: " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}
