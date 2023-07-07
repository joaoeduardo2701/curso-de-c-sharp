using System;
using System.Globalization;

namespace aula42
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto(); 
            
            // Pedindo dados do produto

            Console.WriteLine("Digite os dados do produto: ");

            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            // Adicionando Produtos ao estoque

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(quantidade); 
            Console.WriteLine("Dados do produto: " + p);

            // Removendo Produtos do estoque

            Console.Write("Digite o número de produtos que deseja remover do estoque: ");
            int quantidadeRemover = int.Parse(Console.ReadLine());

            p.RemoverProdutos(quantidadeRemover);
            Console.WriteLine("Dados do produto: " + p);

        }
    }
}
