using System;
using System.Globalization;


namespace Salario_do_funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            double horasTrabalhada, salary, valorHora;

            Console.WriteLine("Digite seu número de identificação: ");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de horas trabalhada: ");
            horasTrabalhada = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da hora: ");
            valorHora = double.Parse(Console.ReadLine());
            
            salary = horasTrabalhada * valorHora;

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
