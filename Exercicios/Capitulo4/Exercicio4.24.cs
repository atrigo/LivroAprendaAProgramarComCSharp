/*
 * Exercicio 4.24
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/


using System;

namespace Cap4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Introduza um nº inteiro: "); // Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {1}",n-1,n+1); 
        }
    }
}
