using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace NotTaxTim.Api.Integrtions.Tests.Infrastructure
{
    public static class ApiWebApplicationFactoryExtensions
    {
        public static WebApplicationFactory<TStartup> Seed<TStartup, TDbContext>(
            this WebApplicationFactory<TStartup> factory,
            Action<TDbContext> seed)
            where TStartup : class
            where TDbContext : DbContext
        {
            using (IServiceScope scope = factory.Server.Services.CreateScope())
            {
                var service = scope.ServiceProvider.GetService<TDbContext>();

                seed(service);
                service.SaveChanges();
            }
            return factory;
        }
    }
}
