using Exercicio3.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> taxPayes = new List<TaxPayer>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Individual or company (i/c)? ");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (char.ToLower(op).Equals('c'))
                {
                    Console.Write("Number of employees: ");
                    int nEmployees = int.Parse(Console.ReadLine());
                    taxPayes.Add(new Company(name, anualIncome, nEmployees));
                }
                else
                {
                    Console.Write("Health expenditures: ");
                    double helthExpen = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayes.Add(new Individual(name, anualIncome, helthExpen));
                }
            }

            Console.WriteLine("TAXES PAID:");
            foreach(TaxPayer t in taxPayes)
                Console.WriteLine(t);
        }
    }
}
