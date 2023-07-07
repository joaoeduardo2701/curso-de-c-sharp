using System;

namespace aula70
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());

            int[] numeros = new int[n1];

            for (int i = 0; i < n1; i++)
            {
                Console.Write($"Digite o {i}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }
            /*
            for (int i = 0; i <= n1; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            */
            Console.WriteLine(numeros[1]);
        }
    }
}
