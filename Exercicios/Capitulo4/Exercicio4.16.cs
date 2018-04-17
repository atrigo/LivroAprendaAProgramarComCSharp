
/*
 * Exercicio 4.16
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
            float b;
            Console.Write("Introduza o preço base: "); // Não é feita validação, ou seja, o utilizador pode introduzir caracteres inválidos
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("PVP={0:F2}EUR",b*1.23); 
        }
    }
}
