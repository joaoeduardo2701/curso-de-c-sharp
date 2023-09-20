using aula135.Entities;
using System;

namespace aula135
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAcount account = new BusinessAcount("Eduardo Padilha", 100.0, 5, 8010);

            Console.WriteLine(account.Balance);

            // account.Balance = 500;
        }
    }
}
