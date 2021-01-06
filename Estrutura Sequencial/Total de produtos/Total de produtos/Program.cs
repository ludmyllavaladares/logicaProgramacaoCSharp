using System;
using System.Globalization;

namespace Total_de_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, cod2, nrPecas1, nrPecas2;
            double valorPecas1, valorPecas2, totalAPagar;

            Console.WriteLine("Digite os códigos:");
            cod1 = int.Parse(Console.ReadLine());
            cod2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de peças:");
            nrPecas1 = int.Parse(Console.ReadLine());
            nrPecas2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor das peças:");
            valorPecas1 = double.Parse(Console.ReadLine());
            valorPecas2 = double.Parse(Console.ReadLine());

            totalAPagar = (nrPecas1 * valorPecas1) + (nrPecas2 * valorPecas2);

            Console.WriteLine("VALOR TOTAL A PAGAR: R$ " + totalAPagar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
