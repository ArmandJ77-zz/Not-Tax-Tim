using Microsoft.EntityFrameworkCore;

namespace DATABASE
{
    public class NotTaxTimDbContext : DbContext
    {
        public NotTaxTimDbContext(DbContextOptions<NotTaxTimDbContext> options)
            : base(options)
        {
        }
    }
}
