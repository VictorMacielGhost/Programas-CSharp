using System;
using System.Globalization;

namespace Primeiro
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Total Em Estoque "
                + Quantidade
                + ", Total: "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
