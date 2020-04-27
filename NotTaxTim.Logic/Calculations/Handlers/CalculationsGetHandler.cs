using MediatR;
using Microsoft.EntityFrameworkCore;
using NotTaxTim.Database;
using NotTaxTim.Logic.Calculations.Queries;
using NotTaxTim.Logic.Calculations.Responses;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace NotTaxTim.Logic.Calculations.Handlers
{
    public class CalculationsGetHandler : IRequestHandler<CalculationsGetQuery, List<CalculationsGetResponse>>
    {
        private readonly NotTaxTimDbContext _dbContext;

        public CalculationsGetHandler(NotTaxTimDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<CalculationsGetResponse>> Handle(CalculationsGetQuery request, CancellationToken cancellationToken)
        {
            var entities = await _dbContext.CalculationResults.ToListAsync(cancellationToken);

            var results = entities.Select(x => x.ToGetResponse())
                .ToList();

            return results;
        }
    }
}