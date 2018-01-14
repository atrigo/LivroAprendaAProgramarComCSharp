/*
 * Memorizar 6.2
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, maior;
            Console.WriteLine("Insira um numero:");
            numero = Convert.ToInt32(Console.ReadLine());
            maior = numero;
            while (numero != 0)
            {
                Console.WriteLine("Insira um numero:");
                numero = Convert.ToInt32(Console.ReadLine());
                if (maior < numero)
                    maior = numero;
            }
            Console.WriteLine("O maior numero e {0}.", maior);
        }
    }
}
