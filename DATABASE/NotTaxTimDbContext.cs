using Microsoft.EntityFrameworkCore;
using NotTaxTim.Database.EntityModels;

namespace NotTaxTim.Database
{
    public class NotTaxTimDbContext : DbContext
    {
        public DbSet<PostalCode> PostalCodes { get; set; }
        public DbSet<TaxCalculationType> TaxCalculationTypes { get; set; }
        public DbSet<CalculationRuleType> CalculationRuleTypes { get; set; }

        public NotTaxTimDbContext(DbContextOptions<NotTaxTimDbContext> options)
            : base(options)
        {
        }
    }
}
