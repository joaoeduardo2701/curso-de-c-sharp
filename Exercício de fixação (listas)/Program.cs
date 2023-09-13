using System;
using System.Collections.Generic;
using System.Globalization;

namespace aula78
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionário vão ser registrados? ");
            int quantidadeFuncionarios = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 1; i <= quantidadeFuncionarios; i++)
            {
                Console.WriteLine("Funcionário #" + i);

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios.Add(new Funcionario(id, nome, salario));
            }

            Console.WriteLine("Lista de funcionarios: ");
            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario);
            }

            Console.Write("Digite o id do funcionário que deseja dar um aumento: ");
            int idAumento = int.Parse(Console.ReadLine());

            Funcionario f = funcionarios.Find(x => x.Id == idAumento);

            if (f != null)
            {
                Console.Write("Digite a porcentagem de aumento: ");
                double porcentagem = double.Parse(Console.ReadLine());
                f.AumentarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Esse id não existe");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizadas de funcionário:");

            foreach(var funcionario in funcionarios)
            {
                Console.WriteLine(funcionario);
            }

        }
    }
}
