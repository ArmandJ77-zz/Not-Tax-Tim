using System.Collections.Generic;
using MediatR;
using NotTaxTim.Logic.Calculations.Responses;

namespace NotTaxTim.Logic.Calculations.Queries
{
    public class CalculationsGetQuery : IRequest<List<CalculationsGetResponse>>
    {
    }
}