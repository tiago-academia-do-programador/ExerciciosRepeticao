using System;

namespace Exercicio02.ConsoleApp
{
    public class Program
    {
        /*
         * Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.
        */
        public static void Main(string[] args)
        {
            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i + " é impar");
            }
        }
    }
}
