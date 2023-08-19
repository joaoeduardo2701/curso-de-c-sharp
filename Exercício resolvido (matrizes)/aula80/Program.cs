using System;
using System.Runtime.InteropServices;

namespace aula80
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o tamanho da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }


            Console.WriteLine("Matriz principal: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }

            Console.WriteLine("\nNúmeros negativos: ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        Console.Write(matriz[i, j] + " ");
                    }
                }
            }
        }
    }
}
