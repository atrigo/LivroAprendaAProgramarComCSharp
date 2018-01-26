/*
 * Exercicio 6.40
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
            int n, i,prod=1; 
            for (i = 0; i < 20; i++)
            {
                do
                {
                    Console.Write("Introduza um nº inteiro entre 10 e 30: ");
                    n = Convert.ToInt32(Console.ReadLine());
                } while (n < 10 || n > 30);
                if (n >= 10 && n <= 20)
                    prod *= n;
            }
            Console.WriteLine("Produto: {0}",prod);
        }
    }
}
