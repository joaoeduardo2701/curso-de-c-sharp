using System;

using aula124.Entities;
using aula124.Entities.Enums;

namespace aula124
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendigPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.Delivered.ToString();

            Console.WriteLine(txt);
        }
    }
}
