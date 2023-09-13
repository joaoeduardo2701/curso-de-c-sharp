using System;

namespace aula72
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int s1 = Calculadora.Soma(new int[] {5, 7});
            Console.WriteLine(s1);
            */

            int s1 = Calculadora.Soma(5, 7);
            int s2 = Calculadora.Soma(10, 17, 15);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }
    }
}
