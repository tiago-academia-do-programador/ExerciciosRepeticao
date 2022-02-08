using System;

namespace Exercicio01.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] alturas = new double[15];

            double maiorAltura = alturas[0];
            double menorAltura = 1;

            int i = 0;
            do
            {
                Console.Write("Qual a altura? ");
                string strAltura = Console.ReadLine();
                alturas[i] = Convert.ToDouble(strAltura);

                if (alturas[i] <= menorAltura)
                    menorAltura = alturas[i];
                
                if (alturas[i] > maiorAltura)
                    maiorAltura = alturas[i];

                i++;
            } while (i < 15);

            Console.WriteLine("A maior altura é: " + maiorAltura);
            Console.WriteLine("A menor altura é: " + menorAltura);
        }
    }
}
