namespace NotTaxTim.Database.EntityModels
{
    public class CalculationRuleType
    {
        public long Id { get; set; }
        public long PostalCodeId { get; set; }
        public long TaxCalculationTypeId { get; set; }

        public PostalCode PostalCode { get; set; }
        public TaxCalculationType TaxCalculationType { get; set; }
    }
}
