/*
 * Exercicio 6.30
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
            int num = 0, r, d, n;
            do
            {
                n = ++num;
                d = n % 10;
                n = n / 10;
                r = n;
                while (n != 0)
                {
                    n = n / 10;
                    d *= 10;
                }
            } while (5 * num != d + r);
            Console.WriteLine("{0}", num);
        }
    }
}
