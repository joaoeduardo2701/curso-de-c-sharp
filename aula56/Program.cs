using System;
using System.Globalization;

namespace aula56
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 1000.57, 10);

            Console.WriteLine(p.Nome);
            p.Nome = "Geladeira";
            Console.WriteLine(p.Nome);

            Console.WriteLine(p.Preco.ToString("F2", CultureInfo.InvariantCulture));

            p.Quantidade = 5;
            Console.WriteLine(p.Quantidade);
        }
    }
}
