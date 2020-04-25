using MediatR;
using NotTaxTim.Logic.Calculations.Queries;
using NotTaxTim.Logic.Calculations.Responses;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace NotTaxTim.Logic.Calculations.Handlers
{
    public class CalculationsGetPagedHandler : IRequestHandler<CalculationsGetPagedQuery, CalculationsGetPagedResponse>
    {
        public Task<CalculationsGetPagedResponse> Handle(CalculationsGetPagedQuery request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}