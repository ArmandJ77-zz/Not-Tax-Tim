using MediatR;
using NotTaxTim.Logic.Calculations.Commands;
using NotTaxTim.Logic.Calculations.Responses;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace NotTaxTim.Logic.Calculations.Handlers
{
    public class CalculationsCreateHandler : IRequestHandler<CalculationsCreateCommand, CalculationsCreateResponse>
    {
        public Task<CalculationsCreateResponse> Handle(CalculationsCreateCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}