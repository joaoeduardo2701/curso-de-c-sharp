using aula135.Entities;
using System;

namespace aula135
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            BusinessAcount account = new BusinessAcount(8010, "Eduardo Padilha", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            // account.Balance = 500;
            */

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAcount bacc = new BusinessAcount(1002, "Maria", 0.0, 500.0);

            // UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAcount(1003, "bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Cleber", 0.0, 0.03);

            // DOWNCASTING

            BusinessAcount acc4 = (BusinessAcount)acc2;
            acc4.Loan(100.0);
            
            if (acc3 is BusinessAcount)
            {
                BusinessAcount acc5 = (BusinessAcount)acc3;
            }
        }
    }
}
