
/*
 * Exercicio 4.19
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
            int idade;
            Console.Write("Qual é a sua idade actual: "); // Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Daqui por vinte anos terá {0} anos",idade+20); 
        }
    }
}
