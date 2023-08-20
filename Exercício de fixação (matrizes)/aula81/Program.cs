using System;
using System.Collections.Generic;

namespace aula81 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de linhas da matriz: ");
            int linhas = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de coluna da matriz: ");
            int colunas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                Console.WriteLine($"Digite a {i + 1}ª linha da matriz: ");
                string[] linha = Console.ReadLine().Split(' ');
                for (int j = 0; j < colunas; j++)
                {
                    matriz[i, j] = int.Parse(linha[j]);
                }
            }

            Console.WriteLine("Digite o número da matriz que deseja verificar: ");
            int n = int.Parse(Console.ReadLine());

            

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0;j < colunas; j++)
                {
                    if (matriz[i, j] == n)
                    {
                        Console.WriteLine($"Posição {i},{j}:");
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[i - 1, j]);
                        }
                        if (i < linhas)
                        {
                            Console.WriteLine("Down: " + matriz[i + 1, j]);
                        }
                        if (j > 0)
                        {
                            Console.WriteLine("Left" + matriz[i, j - 1]);
                        }
                        if (j < linhas)
                        {
                            Console.WriteLine("Right" + matriz[i, j + 1]);
                        }
                    }
                }
            }
        }
    }
}
