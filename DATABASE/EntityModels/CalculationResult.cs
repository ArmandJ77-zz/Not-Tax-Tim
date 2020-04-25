using System;

namespace NotTaxTim.Database.EntityModels
{
    public class CalculationResult
    {
        public long Id { get; set; }
        public long PostalCodeId { get; set; }
        public long TaxCalculationType { get; set; }
        public decimal AnnualIncome { get; set; }
        public decimal TotalTax { get; set; }
        public DateTime DateCreated { get; set; }

        public PostalCode PostalCode { get; set; }
        public TaxCalculationType CalculationType { get; set; }
    }
}
