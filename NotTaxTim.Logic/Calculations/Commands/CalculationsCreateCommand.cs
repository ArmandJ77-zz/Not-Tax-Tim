using System.Reflection.Metadata.Ecma335;
using MediatR;
using NotTaxTim.Logic.Calculations.Responses;

namespace NotTaxTim.Logic.Calculations.Commands
{
    public class CalculationsCreateCommand : IRequest<CalculationsCreateResponse>
    {
        public int PostalCode { get; set; }
        public decimal AnnualIncome { get; set; }
    }
}