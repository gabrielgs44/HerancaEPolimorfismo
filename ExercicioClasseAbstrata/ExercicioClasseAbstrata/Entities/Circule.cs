using ExercicioClasseAbstrata.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioClasseAbstrata.Entities
{
    class Circule : Shape
    {
        public double Radius { get; set; }

        public Circule(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2.0);
        }
    }
}
