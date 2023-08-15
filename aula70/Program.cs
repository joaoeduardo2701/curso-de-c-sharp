using System;
using System.Globalization;

namespace aula70
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de produtos: ");
            int n1 = int.Parse(Console.ReadLine());

            double[] precos = new double[n1];

            double somaPreco = 0.0;

            for (int i = 0; i < n1; i++)
            {
                Console.Write($"Digite o nome do {i + 1}º produto: ");
                Console.ReadLine();

                Console.Write($"Digite o preço do produto: ", CultureInfo.InvariantCulture);
                precos[i] = double.Parse(Console.ReadLine());

                somaPreco += precos[i];
            } 

            double media = somaPreco / n1;
            Console.WriteLine("Média: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
