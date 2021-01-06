using System;

namespace Senha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua senha de quatro dígitos:");

            int senha;
            senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha inválida! Digite novamente");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso permitido!");
            
        }
    }
}
