using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1.Entities
{
    class OutsourcedEmplyoee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmplyoee(string name = null, int hours = 0, double valuePerHour = 0, double additionalCharge = 0) 
            :base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
