using System;

namespace aula150
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Type a number: ");
                int n1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Type another number: ");
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);
            } 
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed!");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error! " + e.Message);
            }
        }
    }
}
