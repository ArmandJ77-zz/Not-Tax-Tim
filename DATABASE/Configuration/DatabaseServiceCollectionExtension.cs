using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DATABASE.Configuration
{
    public static class DatabaseServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, string dbConnectionString)
        {
            services.AddDbContext<NotTaxTimDbContext>(o => o.UseNpgsql(dbConnectionString));
            return services;
        }
    }
}
