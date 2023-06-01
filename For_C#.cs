using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treino
{
    internal class Program
    {
        /* Parecido como programa apresentado no exemplo anterior, neste exemplo iremos
          verificar se o numero digitado pelo usuário é par e somente se for par iremos
          acrescentar ao somador.
         */
        static void Main(string[] args)
        {//inicio
            double soma, num, med, r;
            int c;

            Console.WriteLine("Digite 10 números");
            soma = 0;

            for (c = 1; c <= 10; c++) 
            {
                num = Convert.ToInt32(Console.ReadLine());
                r  = num % 2;
                if (r == 0)
                {
                    soma += num;
                }
            }
            med = soma / 10;
            Console.WriteLine("Digite 10 números" + med);
            Console.ReadKey();
            

        }//fim
    }
}
