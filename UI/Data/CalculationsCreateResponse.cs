namespace UI.Data
{
    public class CalculationsCreateResponse
    {
        public long Id { get; set; }
        public string PostalCode { get; set; }
        public decimal AnnualIncome { get; set; }
        public decimal TotalTax { get; set; }
        public decimal NetPay { get; set; }
    }
}
