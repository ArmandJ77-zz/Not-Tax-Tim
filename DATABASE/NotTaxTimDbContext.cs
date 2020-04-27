using Microsoft.EntityFrameworkCore;
using NotTaxTim.Database.EntityModels;
using System.Linq;

namespace NotTaxTim.Database
{
    public class NotTaxTimDbContext : DbContext
    {
        public DbSet<PostalCode> PostalCodes { get; set; }
        public DbSet<TaxCalculationType> TaxCalculationTypes { get; set; }
        public DbSet<CalculationRuleType> CalculationRuleTypes { get; set; }
        public DbSet<CalculationResult> CalculationResults { get; set; }
        public NotTaxTimDbContext(DbContextOptions<NotTaxTimDbContext> options)
            : base(options)
        {
        }
//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (optionsBuilder.Options.Extensions.All(e =>
//                e.GetType().FullName !=
//                "Microsoft.EntityFrameworkCore.InMemory.Infrastructure.Internal.InMemoryOptionsExtension")) ;
//        }

    }
}
