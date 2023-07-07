using System;
using System.Globalization;

namespace aula48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a cotação do dólar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares deseja comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em R$" + ConversorDeMoeda.Real(cotacao, quantidade).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
 