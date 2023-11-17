using System;
using System.Globalization;

namespace aula60
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial? ");
            char depositoInicial = char.Parse(Console.ReadLine());
            
            ContaBancaria cb = new ContaBancaria(numero, titular);
            double valorDeposito = 0.0;

            if (depositoInicial == 's')
            {
                Console.Write("Digite o valor do depósito inicial: ");
                 valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                 cb.Deposito(valorDeposito);
            }
            else
            {
                cb.Deposito(valorDeposito);
            }

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(cb);

            Console.Write("Entre com um valor para depósito: ");
            valorDeposito = double.Parse(Console.ReadLine());
            cb.Deposito(valorDeposito);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cb);

            Console.Write("Digite um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cb.Saque(valorSaque);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(cb);
        }
    }
}
