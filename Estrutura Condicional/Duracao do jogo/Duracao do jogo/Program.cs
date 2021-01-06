using System;

namespace Duracao_do_jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, duracao;

            horaInicial = int.Parse(Console.ReadLine());
            horaFinal = int.Parse(Console.ReadLine());

            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
              duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("A duração foi de: " + duracao + " hora(s)");
        }
    }
}
