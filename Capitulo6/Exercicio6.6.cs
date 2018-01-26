/*
 * Exercicio 6.6
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap6
{
    class Program
    {
        static void Main(string[] args) //o expoente deve ser zero ou um inteiro positivo 
        {
            int b, e, i, pot=1; // o elemento neutro da multiplicação é 1
            Console.Write("Introduza o valor da base: ");     // Não é feita validação, ou seja, o utilizador pode  introduzir 
            b = Convert.ToInt32(Console.ReadLine());            //valores incorrectos ou caracteres inválidos e  como tal gerar excepções (ERROS)
            Console.Write("Introduza o valor do expoente: ");
            e = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < e; i++)
                pot *= b; // ou pot= pot*b;
            Console.Write("{0}^{1}={2}\n",b,e,pot); 
        }
    }
}

