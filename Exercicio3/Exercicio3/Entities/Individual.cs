using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3.Entities
{
    class Individual : TaxPayer
    {
        public double HearthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double hearthExpenditures)
            : base(name, anualIncome)
        {
            HearthExpenditures = hearthExpenditures;
        }

        public override double Tax()
        {
            double tax;

            tax = AnualIncome < 20000.00 ? 
                (AnualIncome * 0.15) - (HearthExpenditures * 0.50) 
                : (AnualIncome * 0.25) - (HearthExpenditures * 0.50);

            return tax;
        }
    }
}
