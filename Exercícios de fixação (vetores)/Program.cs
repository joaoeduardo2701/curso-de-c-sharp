using System;

namespace aula71
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int quantidadeQuartos = int.Parse(Console.ReadLine());

            Aluguel[] a = new Aluguel[10];

            for (int i = 0; i < quantidadeQuartos; i++)
            {
                Console.WriteLine($"Aluguel #{i + 1}");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Número do quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                a[i] = new Aluguel { Nome = nome, Email = email, Quarto = quarto};
            }

            for (int i = 0; i < quantidadeQuartos; i++)
            {
                Console.WriteLine(a[i]);
            }
            // Console.WriteLine("Nome: " + a[0].Nome);
        }
    }
}
