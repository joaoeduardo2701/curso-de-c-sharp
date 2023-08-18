using System;

namespace aula73
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int n = 5;
            Calculator.Triple(ref n);
            Console.WriteLine($"O triplo do número é {n}");
            */

            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);
            Object obj = a;
            Console.WriteLine(obj);

        }
    }
}
