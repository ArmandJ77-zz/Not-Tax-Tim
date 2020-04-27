using System;

namespace NotTaxTim.Logic.Calculations.Responses
{
    public class CalculationsGetResponse
    {
        public long Id { get; set; }
        public long PostalCodeId { get; set; }
        public long TaxCalculationType { get; set; }
        public decimal AnnualIncome { get; set; }
        public decimal TotalTax { get; set; }
        public DateTime DateCreated { get; set; }

    }
}