using System;
using System.Globalization;

namespace aula69
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());

            double[] vetor = new double[n1];
            double somaAlturas = 0.0;

            for (int i = 0; i < n1; i++)
            {
                Console.Write($"Digite a {i}ª altura: ", CultureInfo.InvariantCulture);
                vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                somaAlturas += vetor[i];
                
            }

            double media = somaAlturas / n1;
            Console.WriteLine("Média: " + media);
        }
    }
}
