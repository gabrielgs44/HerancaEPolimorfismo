using System;

namespace Exercicio2.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufacureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufacureDate) : base(name, price)
        {
            ManufacureDate = manufacureDate;
        }

        public override string PriceTag()
        {
            return $"(used) {base.PriceTag()} (Manufacture date: {ManufacureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
