using System;
using System.Globalization;

namespace Media_de_aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, notaFinal;
            
            Console.WriteLine("Digite suas notas:");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            notaFinal = nota1 + nota2;

            Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F1", CultureInfo.InvariantCulture));

            if (notaFinal >= 60.0)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
            }
              
        }
    }
}
