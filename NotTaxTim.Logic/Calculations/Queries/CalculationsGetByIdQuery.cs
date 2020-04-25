using MediatR;
using NotTaxTim.Logic.Calculations.Responses;

namespace NotTaxTim.Logic.Calculations.Queries
{
    public class CalculationsGetByIdQuery : IRequest<CalculationsGetByIdResponse>
    {
    }
}