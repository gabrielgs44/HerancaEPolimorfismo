using System.Globalization;
using System.Text;

namespace Exercicio2.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            return $"$ {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name} {PriceTag()}");
            return sb.ToString();
        }

    }
}
