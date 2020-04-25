using Microsoft.EntityFrameworkCore;
using NotTaxTim.Database.EntityModels;

namespace DATABASE
{
    public class NotTaxTimDbContext : DbContext
    {
        public DbSet<PostalCode> PostalCodes { get; set; }

        public NotTaxTimDbContext(DbContextOptions<NotTaxTimDbContext> options)
            : base(options)
        {
        }
    }
}
