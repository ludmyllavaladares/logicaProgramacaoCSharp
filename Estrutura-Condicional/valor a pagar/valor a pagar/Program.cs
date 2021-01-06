using System;
using System.Globalization;

namespace valor_a_pagar
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod, qtdeItem;
            double total;

            cod = int.Parse(Console.ReadLine());
            qtdeItem = int.Parse(Console.ReadLine());

            if (cod == 1)
            {
                total = qtdeItem * 4.0;
            }
            else if (cod == 2) 
            {
                total = qtdeItem * 4.5;
            }
            else if (cod == 3)
            {
                total = qtdeItem * 5.0;
            }
            else if (cod == 4)
            {
                total = qtdeItem * 2.0;
            }
            else 
            {
                total = qtdeItem * 1.5;
            }
            Console.WriteLine("O total da conta a pagar é: " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
