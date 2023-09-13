using System;

namespace aula75
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "João", "Maria", "Leonardo" };

            for (int n = 0; n < nomes.Length; n++)
            {
                Console.WriteLine(nomes[n]);
            }

            foreach (string nome in nomes)
            {
                Console.WriteLine($"{nome} sa primeira letra do seu nome é {nome[0]}");
            }
        }
    }
}
