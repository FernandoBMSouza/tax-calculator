using System;
namespace Project.Entities
{
    class Company : Taxpayer
    {
        public int NumberOfEmployees { get; set; }
        public Company(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }
        public override double TaxCalculator()
        {
            if(NumberOfEmployees > 10)
            {
                return AnnualIncome * 14 / 100;
            }
            else
            {
                return AnnualIncome * 16 / 100;
            }
        }
    }
}