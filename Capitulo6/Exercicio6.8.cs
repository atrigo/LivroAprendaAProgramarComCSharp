/*
 * Exercicio 6.8
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
            int n, soma=0;
            do
            {
                Console.Write("Introduza um nº inteiro (zero para sair): ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                    soma += n;
            } while (n != 0); 
            Console.WriteLine("Soma dos inteiros positivos: {0}",soma); 
        }
    }
}

