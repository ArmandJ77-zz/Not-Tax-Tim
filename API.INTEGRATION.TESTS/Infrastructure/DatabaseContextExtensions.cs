using Microsoft.EntityFrameworkCore;
using NotTaxTim.Database;

namespace NotTaxTim.Api.Integrtions.Tests.Infrastructure
{
    public static class DatabaseContextExtensions
    {
        public static void Clear(this NotTaxTimDbContext db)
        {
            db.TaxCalculationTypes.Clear();
            db.PostalCodes.Clear();
            db.CalculationRuleTypes.Clear();
            db.CalculationResults.Clear();
            db.SaveChanges();
        }

        public static void Clear<T>(this DbSet<T> dbSet) where T : class
        {
            dbSet.RemoveRange(dbSet);
        }
    }
}
