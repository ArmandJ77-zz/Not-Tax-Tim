using MediatR;
using NotTaxTim.Logic.Calculations.Responses;

namespace NotTaxTim.Logic.Calculations.Commands
{
    public class CalculationsDeleteCommand : IRequest<CalculationsDeleteResponse>
    {
    }
}