using ExercicioClasseAbstrata.Entities;
using ExercicioClasseAbstrata.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            List<Shape> shapes = new List<Shape>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i+1}:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char op = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                switch (op)
                {
                    case 'r':
                        Console.Write("Width: ");
                        double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Height: ");
                        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        shapes.Add(new Rectangle(width, height, color));
                        break;
                    case 'c':
                        Console.Write("Radius: ");
                        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        shapes.Add(new Circule(radius, color));
                        break;
                    default:
                        Console.WriteLine("invalid option, type r for rectangle or c for circle. Try Again!");
                        i--;
                        break;
                }


            }

            Console.WriteLine("SHAPE AREAS");
            foreach(Shape s in shapes)
            {
                Console.WriteLine(s);
            }
        }
    }
}
