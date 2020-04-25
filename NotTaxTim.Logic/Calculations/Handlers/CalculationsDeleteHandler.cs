using MediatR;
using NotTaxTim.Logic.Calculations.Commands;
using NotTaxTim.Logic.Calculations.Responses;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace NotTaxTim.Logic.Calculations.Handlers
{
    public class CalculationsDeleteHandler : IRequestHandler<CalculationsDeleteCommand, CalculationsDeleteResponse>
    {
        public Task<CalculationsDeleteResponse> Handle(CalculationsDeleteCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}