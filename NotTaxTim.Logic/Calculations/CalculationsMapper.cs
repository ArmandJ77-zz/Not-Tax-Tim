using NotTaxTim.Database.EntityModels;
using NotTaxTim.Logic.Calculations.Responses;

namespace NotTaxTim.Logic.Calculations
{
    public static class CalculationsMapper
    {
        public static CalculationsCreateResponse ToCreateResponse(this CalculationResult calculationResult)
        {
            var result = new CalculationsCreateResponse
            {
                Id = calculationResult.Id,
                PostalCode = calculationResult.PostalCode.Code,
                AnnualIncome = calculationResult.AnnualIncome,
                TotalTax = calculationResult.TotalTax
            };

            return result;
        }
    }
}
