using Exercicio1.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());


            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employee #{i + 1} data: ");
                Console.Write("Outsourced (y/n)? ");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hour = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (op.Equals('y'))
                {
                    Console.Write("Additional charge: ");
                    double additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmplyoee(name, hour, valueHour, additional));
                }
                else
                {
                    employees.Add(new Employee(name, hour, valueHour));
                }
            }

            foreach (Employee e in employees)
                Console.WriteLine(e);
        }
    }
}
