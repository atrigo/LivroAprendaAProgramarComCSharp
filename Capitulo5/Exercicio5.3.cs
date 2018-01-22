/*
 * Exercicio 5.3
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Introduza um número inteiro: "); // Não é feita validação, ou seja, o utilizador pode introduzir um nº real ou caracteres inválidos
            i = Convert.ToInt32(Console.ReadLine()); 
            if (i>0 && i%2==0)   // a segunda parte da expressão (i%2==0) só é avaliada se da primeira resultar o valor true 
                Console.WriteLine("O número inteiro {0} é positivo e par",i); 
            else
                Console.WriteLine("O número inteiro {0} não é positivo e par",i); 
        }
    }
}
