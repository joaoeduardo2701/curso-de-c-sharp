using System;
using System.Globalization;

namespace aula55
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 1000.57, 10);

            Console.WriteLine(p.GetNome());
            p.SetNome("Geladeira");
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(p.GetQuantidade());
        }
    }
}
