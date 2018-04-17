/*
 * Exercicio 6.36
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
            uint i, j, k, n;
            uint[] v = new uint[9];
            bool cap;
            for (i = 1; i < 10000; i++)
            {
                n = i;
                j = 0;
                do
                {
                    v[j++] = n % 10;
                    n /= 10;
                }
                while (n > 0);
                cap = true;
                k = 0;
                do
                    if (v[j - 1 - k] != v[k++])
                        cap = false;
                while (j / 2 >= k && cap);
                if (cap)
                    Console.WriteLine(i);
            }
        }
    }
}
