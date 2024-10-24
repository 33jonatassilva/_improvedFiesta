using System.Globalization;

namespace Ex0001
{
    class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double TotalValueInStock()
        {
            return Price * Quantity;
        }

        public void AddProducts(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoveProducts(int quantity)
        {
            Quantity -= quantity;
        }

        public override string ToString()
        {
            return Name
                   + ", $ "
                   + Price.ToString("F2", CultureInfo.InvariantCulture)
                   + ", "
                   + Quantity
                   + " unidades, Total: $ "
                   + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}