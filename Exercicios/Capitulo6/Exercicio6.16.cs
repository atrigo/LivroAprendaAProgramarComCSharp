/*
 * Exercicio 6.16
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
            int N, n;
            double soma = 0;
            Console.Write("Quantas noites:");
            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("S=");
            for (n = 1; n < N; n++)
            {
                soma += 50F / n;
                Console.Write("{0}/{1}+", 50, n);
            }
            Console.WriteLine("{0}/{1}\nSoma={2}", 50, n, soma += 50F / n);
        }
    }
}
