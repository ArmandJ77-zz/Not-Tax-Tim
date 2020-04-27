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
                TotalTax = calculationResult.TotalTax,
                NetPay = calculationResult.NetPay

            };

            return result;
        }

        public static CalculationsGetResponse ToGetResponse(this CalculationResult calculationResult)
        {
            var result = new CalculationsGetResponse
            {
                Id = calculationResult.Id,
                AnnualIncome = calculationResult.AnnualIncome,
                TaxCalculationType = calculationResult.TaxCalculationType,
                TotalTax = calculationResult.TotalTax,
                PostalCodeId = calculationResult.PostalCodeId,
                DateCreated = calculationResult.DateCreated,
                NetPay = calculationResult.NetPay
            };

            return result;
        }
    }
}
