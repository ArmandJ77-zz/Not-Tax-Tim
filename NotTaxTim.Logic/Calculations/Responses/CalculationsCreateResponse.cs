namespace NotTaxTim.Logic.Calculations.Responses
{
    public class CalculationsCreateResponse
    {
        public long Id { get; set; }
        public int PostalCode { get; set; }
        public decimal AnnualIncome { get; set; }
        public decimal TotalTax { get; set; }
    }
}