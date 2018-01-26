/*
 * Exercicio 6.34
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
            ulong j, m = 2, n, k = 0;
            bool primo = true;
            for (n = 2; n < 62; n++) // Dependendo do computador o último número pode demorar mais de 1 minuto a ser calculado
            {
                m = m * 2 - 1;
                primo = true;
                j = 1;
                while (++j <= (Math.Sqrt(m)) && primo)
                    if (m % j == 0)
                        primo = false;
                if (primo)
                    Console.WriteLine(m);
                k += j - 2;
                m++;
            }
            Console.WriteLine("\n\n\t ****** {0} Iterações ******\n\n", k);
        }
    }
}
