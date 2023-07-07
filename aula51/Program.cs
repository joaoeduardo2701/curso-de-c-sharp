using Course;
using System;
using System.Globalization;

namespace aula51
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 1000.0, 5);

            Console.WriteLine(p.Preco);


            Console.WriteLine(p.Quantidade);
        }
    }
}
