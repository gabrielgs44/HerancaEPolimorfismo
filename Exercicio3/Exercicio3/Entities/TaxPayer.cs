﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio3.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }
        public abstract double Tax();
        public override string ToString()
        {
            return $"{Name}: $ {Tax().ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
