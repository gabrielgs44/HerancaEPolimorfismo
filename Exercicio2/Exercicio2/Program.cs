using Exercicio2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Common, used or imported (c/u/i)? ");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (op)
                {
                    case 'c':
                            products.Add(new Product(name, price));
                            break;      
                    case 'i':      
                            Console.WriteLine("Customs fee: ");
                            double custom = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            products.Add(new ImportedProduct(name, price, custom) as Product);
                            break;
                    case 'u':
                            Console.Write("Manufacture date (DD/MM/YYYY): ");
                            DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                            products.Add(new UsedProduct(name, price, manufactureDate) as Product);
                            break;      
                    default:
                        Console.WriteLine("invalid option, type again!");
                        i--;
                        break;
                }
            }
            Console.WriteLine("PRICE TAGS:");
            foreach (Product p in products)
                Console.WriteLine(p);
        }
    }
}
