/*
 * Exercicio 6.18
 * Enunciado:   Altere o programa de cálculo dos números primos, apresentando, caso o número não seja primo, 
 *              os números pelos quais ele é divisível.
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, n, i,cont=0;
            Console.Write("Introduza o valor de N:");
            N = Convert.ToInt32(Console.ReadLine());
            for (n = 2; n <= N; n++)
            {
                for (i = 2; i <= Math.Sqrt(n); i++)
                {
                    cont++;
                    if (n % i == 0)
                        break;
                }
                if(i > Math.Sqrt(n))
                    Console.Write(" {0}",n);
            }
            Console.WriteLine("\nForam efectuadas {0} divisões", cont);
        }
    }
}
