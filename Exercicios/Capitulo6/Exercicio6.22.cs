/*
 * Exercicio 6.22
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
            int n, idade, i, soma=0;
            Console.Write("Quantos alunos tem a turma: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                for (i = 1; i < n; i++)
                {
                    Console.Write("Introduza a idade do aluno: ");
                    idade = Convert.ToInt32(Console.ReadLine());
                    soma += idade;
                }
                if((float)soma/n <26)
                    Console.WriteLine("A turma é jovem"); 
                else
                    if((float)soma/n <=60)
                        Console.WriteLine("A turma é adulta"); 
                    else
                        Console.WriteLine("A turma é idosa"); 
            }
            else
                Console.WriteLine("A turma não tem alunos"); 
        }
    }
}
