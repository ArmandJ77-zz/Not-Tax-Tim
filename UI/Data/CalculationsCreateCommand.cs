using System.ComponentModel.DataAnnotations;

namespace UI.Data
{
    public class CalculationsCreateCommand
    {
        [Required]
        public string PostalCode { get; set; }

        //WHY NO VALIDATION
        //BECAUSE BLAZOR IS POTATO: https://github.com/dotnet/aspnetcore/issues/5523
        [Required]
        public decimal AnnualIncome { get; set; }
    }
}
