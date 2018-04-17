/*
 * Exercicio 6.3
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
            int i,soma;
            soma = 0;
            for (i = 4; i < 100; i+=3)
                soma += i;
            Console.WriteLine("Soma:{0}",soma);
            soma = 0; //Após a execução do ciclo for é necessário repor os valores das variáveis soma e i
            i = 4;
            while(i < 100)
            {
                soma += i;
                i += 3;
            }
            Console.WriteLine("Soma:{0}",soma);
            soma = 0;//Após a execução do ciclo while é necessário repor os valores das variáveis soma e i
            i = 4;
            do
            {
                soma += i;
                i += 3;
            } while (i < 100);
            Console.WriteLine("Soma:{0}",soma);
        }
    }
}
