using System;
using System.Globalization;
using aula132.Entities;
using aula132.Entities.Enums;

namespace aula132
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime datetime = DateTime.Parse(Console.ReadLine());


            Console.WriteLine("Enter order data");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus> (Console.ReadLine());

            Client client = new Client(name, email, datetime);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int amount = int.Parse(Console.ReadLine()); 

            for (int i = 1; i <= amount; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderitem = new OrderItem(quantity, productPrice, product);

                order.AddItem(orderitem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
