using FluentValidation;
using NotTaxTim.Logic.Calculations.Commands;

namespace NotTaxTim.Logic.Calculations.Validators
{
    public class CalculationCreateValidator: AbstractValidator<CalculationsCreateCommand>
    {
        public CalculationCreateValidator()
        {
            RuleFor(x => x.PostalCode)
                .NotEmpty()
                .NotNull();

            RuleFor(x => x.AnnualIncome)
                .NotEmpty()
                .GreaterThanOrEqualTo(0)
                .NotNull();
        }
    }
}
