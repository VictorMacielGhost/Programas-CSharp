using System;
using System.Globalization;

namespace Primeiro
{
    class programa3
    {
        public void Aaaa()
       // static void Main(string[] args)
        {

            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade No Estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " +  p);

            Console.Write("Digite a quantidade de produtos para remover do estoque: ");
            int quantia = int.Parse(Console.ReadLine());
            p.RemoverProdutos(quantia);
            Console.WriteLine("Dados Atualizados: " + p);

            Console.Write("Digite a quantidade de produtos para adicionar do estoque: ");
            quantia = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(quantia);
            Console.WriteLine("Dados Atualizados: " + p);

        }
    }
}
    