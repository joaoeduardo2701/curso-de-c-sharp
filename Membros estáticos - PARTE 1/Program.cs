using System;

namespace aula46
{
    class Program
    {
        static double Pi = 3.14;

        static void Main(string[] args)
        {
            Console.Write("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circunferencia = Circunferencia(raio);
            Console.WriteLine("Circunferência: " + circunferencia);

            double volume = Volume(raio);
            Console.WriteLine("Volume: " + volume);

            Console.WriteLine("Valor de Pi: " + Pi);
        }

        static double Circunferencia(double raio)
        {
            return 2 * Pi * raio;
        }

        static double Volume(double raio)
        {
            return (4 * Pi * Math.Pow(raio, 3)) / 3;
        }
    }
}
