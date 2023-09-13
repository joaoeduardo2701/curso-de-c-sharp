using System;
using System.Collections.Generic;

namespace aula77
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            // Adicionando elementos na lista

            list.Add("Pedro");
            list.Add("Cleber");

            list.Insert(0, "Rodrigo");
            list.Insert(1, "César");

            foreach (string nome in list)
            {
                Console.WriteLine($"Olá, {nome} é um prazer te conhecer");
            }

            Console.WriteLine(" ");
            Console.WriteLine("List count: " +  list.Count);
            Console.WriteLine(" ");

            // Encontrando elementos

            string s1 = list.Find(Test);
            Console.WriteLine("Primeira pessoa com a letra C: " + s1);

            string s2 = list.FindLast(Test);
            Console.WriteLine("ùltima pessoa com a letra: " + s2);

            int pos1 = list.FindIndex(Test);
            Console.WriteLine("Posição da primeira pessoa que começa com a letra C: " + pos1);

            int pos2 = list.FindLastIndex(Test);
            Console.WriteLine("Posição da primeira pessoa que começa com a letra C: " + pos2);

            Console.WriteLine(" ");

            // Filtrando a lista

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("Nomes que tem 5 letras: ");
            foreach (string nome in list2)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine(" ");

            // Removendo itens

            list.Remove("Cleber");

            foreach (string nome in list)
            {
                Console.Write(nome + " ");
            }

            list.RemoveAll(x => x[0] == 'R');

            Console.WriteLine("\n-----------------");

            foreach (string nome in list)
            {
                Console.Write(nome + " ");
            }

            Console.WriteLine("\n-----------------");

            list.RemoveAt(0);
        }

        static bool Test(string s)
        {
            return s[0] == 'C';
        }
    }
}
