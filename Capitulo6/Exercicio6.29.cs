/*
 * Exercicio 6.29
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
            int n, soma = 0;
            Console.Write("Quantas entradas para menores de 4 anos? ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quantas entradas para crianças entre os 6 e os 12 anos? ");
            n = Convert.ToInt32(Console.ReadLine());
            soma += 6 * n;
            Console.Write("Quantas entradas para crianças entre os 12 e os 17 anos? ");
            n = Convert.ToInt32(Console.ReadLine());
            soma += 12 * n;
            Console.Write("Quantas entradas para adultos? ");
            n = Convert.ToInt32(Console.ReadLine());
            soma += 18 * n;
            Console.WriteLine("Total: {0}",soma);
        }
    }
}
