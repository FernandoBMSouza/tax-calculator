using System;

namespace Project.Entities
{
    class Individual : Taxpayer
    {
        public double HealthExpenditures { get; set; }
        public Individual(string name, double annualIncome, double healthExpentitures) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpentitures;
        }
        public override double TaxCalculator()
        {
            double tax;
            if(AnnualIncome < 20000.00)
            {
                if(HealthExpenditures > 0)
                {
                    return (AnnualIncome * 15 / 100) - (HealthExpenditures * 50 / 100);
                }
                else
                {
                    return AnnualIncome * 15 / 100;
                }
            }
            else
            {
                if(HealthExpenditures > 0)
                {
                    return (AnnualIncome * 25 / 100) - (HealthExpenditures * 50 / 100);
                }
                else
                {
                    return AnnualIncome * 25 / 100;
                }
            }
        }
    }
}