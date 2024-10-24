using System;
using System.Globalization;

namespace Ex0001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do Product:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantity = int.Parse(Console.ReadLine());

            Product p = new Product(name, price, quantity);

            Console.WriteLine();
            Console.WriteLine("Dados do Product: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de Products a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AddProducts(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de Products a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoveProducts(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p.ToString());
        }
    }
}