
/*
 * Exercicio 4.12
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
            float lado;
            Console.Write("Introduza o valor do lado do quadrado: "); // Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            lado = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Área:{0}\nPerímetro:{1}",lado*lado,4*lado); // \n - mudança de linha
        }
    }
}

