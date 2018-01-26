/*
 * Exercicio 6.1. Números impares entre 1 e 50
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

//Versao 1
using System;

namespace Cap6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for(i=1;i<=50;i+=2)
                Console.WriteLine(i);
        }
    }
}

//Versao 2
using System;

namespace Cap6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for(i=1;i<=50;i++)
                if(i%2==1)
                    Console.Write("{0} ",i);
            Console.WriteLine();
        }
    }
}
