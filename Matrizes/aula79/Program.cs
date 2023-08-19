using System;

namespace aula79
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[2, 3];

            Console.WriteLine(matriz.Length); // Quantiadade de espaços na matriz
             
            Console.WriteLine(matriz.Rank); // Mostra a primeira dimenção da matriz, ou seja, as linhas

            Console.WriteLine(matriz.GetLength(0)); // Mostra a quantidade de linhas da matriz
            Console.WriteLine(matriz.GetLength(1)); // Mostra a quantidade de colunas da matriz

        }
    }
}
 