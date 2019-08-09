using System.Globalization;

namespace Exercicio2.Entities
{
    class ImportedProduct: Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(string name, double price, double customsPrice) :base(name, price)
        {
            CustomsFee = customsPrice;
        }
        public override string PriceTag()
        {
            return $"{Totalprice().ToString("F2", CultureInfo.InvariantCulture)} (CustomsFee fee: $ 20.00)";
        }
        public double Totalprice()
        {
            return Price + CustomsFee;
        }
    }
}
