using NotTaxTim.Logic.Calculations.Models;
using System;
using System.Collections.Generic;

namespace NotTaxTim.Logic.Calculations.Builders
{
    public static class CalculationBuilder
    {
        public static decimal CalculateFlatValue(decimal annualIncome)
            => (annualIncome < 200000) ? annualIncome * (decimal)0.05 : 10000;

        public static decimal CalculateFlatRate(decimal annualIncome)
            => annualIncome * (decimal)0.175;

        public static decimal CalculateProgressive(decimal annualIncome)
        {
            var progressiveTaxModels = new List<ProgressiveTaxModel>
            {
                new ProgressiveTaxModel
                {
                    Min = 0,
                    Max = 8350,
                    Rate = (decimal) 0.10
                },
                new ProgressiveTaxModel
                {
                    Min = 8351,
                    Max = 33950,
                    Rate = (decimal) 0.15
                },
                new ProgressiveTaxModel
                {
                    Min = 33951,
                    Max = 82250,
                    Rate = (decimal) 0.25
                },
                new ProgressiveTaxModel
                {
                    Min = 82251,
                    Max = 171550,
                    Rate =(decimal) 0.28
                },
                new ProgressiveTaxModel
                {
                    Min = 171551,
                    Max = 372950,
                    Rate = (decimal) 0.33
                },
                new ProgressiveTaxModel
                {
                    Min = 372951,
                    Max = Decimal.MaxValue,
                    Rate =(decimal) 0.35
                }
            };

            decimal payableTax = 0;

            foreach (var taxModel in progressiveTaxModels)
            {
                if (annualIncome >= taxModel.Min && annualIncome <= taxModel.Max)
                {
                    var taxableIncomeForBracket = annualIncome - taxModel.Min;
                    var calcTax = taxableIncomeForBracket * taxModel.Rate;
                    payableTax += calcTax;
                    continue;
                }

                if (annualIncome > taxModel.Max)
                {
                    var calcTax = taxModel.Max * taxModel.Rate;
                    payableTax += calcTax;
                }
            }

            return payableTax;
        }
    }
}
