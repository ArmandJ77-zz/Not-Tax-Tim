using MediatR;
using Microsoft.EntityFrameworkCore;
using NotTaxTim.Database;
using NotTaxTim.Database.EntityModels;
using NotTaxTim.Logic.Calculations.Builders;
using NotTaxTim.Logic.Calculations.Commands;
using NotTaxTim.Logic.Calculations.Responses;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace NotTaxTim.Logic.Calculations.Handlers
{
    public class CalculationsCreateHandler : IRequestHandler<CalculationsCreateCommand, CalculationsCreateResponse>
    {
        private readonly NotTaxTimDbContext _dbContext;

        public CalculationsCreateHandler(NotTaxTimDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CalculationsCreateResponse> Handle(CalculationsCreateCommand request, CancellationToken cancellationToken)
        {
            var postalCodeEntity = await _dbContext.PostalCodes.FirstOrDefaultAsync(
                x => x.Code == request.PostalCode
                , cancellationToken);

            var calculationType =
                await _dbContext.CalculationRuleTypes.FirstOrDefaultAsync(
                    x => x.PostalCodeId == postalCodeEntity.Id,
                    cancellationToken: cancellationToken);

            var payableTax = calculationType.TaxCalculationTypeId switch
            {
                1 => CalculationBuilder.CalculateProgressive(request.AnnualIncome),
                2 => CalculationBuilder.CalculateFlatValue(request.AnnualIncome),
                3 => CalculationBuilder.CalculateFlatRate(request.AnnualIncome),
                _ => throw new NotImplementedException(),
            };

            var entity = new CalculationResult
            {
                AnnualIncome = request.AnnualIncome,
                PostalCodeId = postalCodeEntity.Id,
                TaxCalculationType = calculationType.Id,
                DateCreated = DateTime.Now,
                TotalTax = payableTax,
                NetPay =  request.AnnualIncome - payableTax
            };

            await _dbContext.CalculationResults.AddAsync(entity, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return entity.ToCreateResponse();
        }
    }
}