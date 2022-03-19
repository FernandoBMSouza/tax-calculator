using System;
using System.Collections.Generic;
using System.Globalization;
using Project.Entities;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<Taxpayer> taxpayers = new List<Taxpayer>();

            for (int i = 1; i <= n; i++)
            {
                System.Console.WriteLine($"Tax payer #{i} data:");
                System.Console.Write("Individual or Company (i/c)? ");
                char c = char.Parse(Console.ReadLine().ToLower());
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Annual Income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(c == 'i')
                {
                    System.Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    taxpayers.Add(new Individual(name, annualIncome, healthExpenditures));
                }
                else if(c == 'c')
                {
                    System.Console.Write("Number of Employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    taxpayers.Add(new Company(name, annualIncome, numberOfEmployees));
                }
                else
                {
                    System.Console.WriteLine("Invalid Value!");
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine("TAXES PAID:");
            double sum = 0;
            foreach (Taxpayer tp in taxpayers)
            {
                System.Console.WriteLine($"{tp.Name}: {tp.TaxCalculator().ToString("F2", CultureInfo.InvariantCulture)}");
                sum += tp.TaxCalculator();
            }
            System.Console.WriteLine();
            System.Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}