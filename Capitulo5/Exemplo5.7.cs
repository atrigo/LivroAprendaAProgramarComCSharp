/*
 * Exemplo 5.7
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/


using System;
namespace ConsoleApp1{
    class Program{
        static void Main(string[] args){
            int valor1, valor2, maior;
            Console.WriteLine("Insira um numero: ");
            valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insira outro numero: ");
            valor2 = Convert.ToInt32(Console.ReadLine());
            if (valor1 > valor2)
                maior = valor1;
            else
                maior = valor2;
            Console.WriteLine("O maior valor de " + valor1 + " e " + valor2 + " e': " + maior);
}}}
