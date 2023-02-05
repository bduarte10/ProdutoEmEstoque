
using System.Globalization;

namespace ProdutoEmEstoque
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string? nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine() ?? "0", CultureInfo.InvariantCulture);
            Console.Write("Quantidade no Estoque: ");
            int quantidade = int.Parse(Console.ReadLine() ?? "0");

            Produto p = new(nome, preco, quantidade);

            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine() ?? "0");
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            int qte2 = int.Parse(Console.ReadLine() ?? "0");
            p.RemoverProdutos(qte2);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}
