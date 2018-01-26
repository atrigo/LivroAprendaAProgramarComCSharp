/*
 * Exercicio 6.12
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
            int i,j,num,r=0;
            Console.Write("Digite um nº:");
            num=Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= 5; i++)
            {
                for(j=1;j<=5;j++)
                    Console.Write("{0,5} ",r+=num);
                Console.WriteLine();
            }
        }
    }
}
