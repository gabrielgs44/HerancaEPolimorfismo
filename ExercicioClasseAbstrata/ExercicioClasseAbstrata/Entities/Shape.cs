using ExercicioClasseAbstrata.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioClasseAbstrata.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

        public override string ToString()
        {
            return $"{Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
