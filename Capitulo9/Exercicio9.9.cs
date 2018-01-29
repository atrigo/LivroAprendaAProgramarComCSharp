/*
 * Exercicio 9.9
 * Livro: Aprenda a programar com C#
 * Autores: Antonio Trigo e Jorge Henriques
 * Disponível em: http://www.silabo.pt
*/

using System;

namespace Cap9
{
    class Program
    {
        static void maiusculas(ref string s)
        {
            char[] v=new char[s.Length];
            for (int j = 0; j <s.Length ; j++)
                if(s[j]>='a'&&s[j]<='z') // Testa se o caráter é uma letra minúscula e portanto suscetível de ser convertido em maiúscula
                    v[j] = (char)(s[j]-32);// A diferença do código ASCII de maiúsculas para minúsculas é 32 (A-65 a-97)
            s = new string(v);
        }
        static void Main(string[] args)
        {
            string s;
            Console.Write("Introduza uma frase: ");
            s = Console.ReadLine();
            maiusculas(ref s); // Sem a utilização da passagem por referência as alterações efectuadas no método insereAster não se refectiriam na função main
            Console.WriteLine(s);
        }
    }
}
