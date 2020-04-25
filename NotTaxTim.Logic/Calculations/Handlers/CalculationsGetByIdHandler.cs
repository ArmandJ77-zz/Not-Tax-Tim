using MediatR;
using NotTaxTim.Logic.Calculations.Queries;
using NotTaxTim.Logic.Calculations.Responses;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace NotTaxTim.Logic.Calculations.Handlers
{
    public class CalculationsGetByIdHandler : IRequestHandler<CalculationsGetByIdQuery, CalculationsGetByIdResponse>
    {
        public Task<CalculationsGetByIdResponse> Handle(CalculationsGetByIdQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}