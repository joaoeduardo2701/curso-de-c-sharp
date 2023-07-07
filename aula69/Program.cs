using System;
using System.Globalization;

namespace aula69
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            double[] numeros = new double[n];

            double soma = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o {i + 1}º altura: ");
                numeros[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (i == 0)
                {
                    soma = numeros[i];
                }
                else
                {
                    soma += numeros[i];
                }
            }

            double media = soma / n;

            Console.WriteLine("Média: " + media.ToString("F2", CultureInfo.InvariantCulture));   
        }
    }
}
