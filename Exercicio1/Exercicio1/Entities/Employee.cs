using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio1.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public Double ValuePerHour { get; set; }

        public Employee(string name = null, int hours = 0, double valuePerHour = 0)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("PAYMENTS:");
            sb.Append($"{Name} - $ {Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
