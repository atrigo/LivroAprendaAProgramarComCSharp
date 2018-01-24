/*
 * Exercicio 4.23
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
            int a=4,b=5;
            Console.WriteLine("a:{0}\tb:{1}",a,b); //faça execução passo a passo (F10) para ver a evolução do conteúdo das variáveis
            a = a + b; // a=9 b=5
            b = a - b; // a=9 b=4
            a = a - b; // a=5 b=4
            Console.WriteLine("a:{0}\tb:{1}",a,b);
        }
    }
}
