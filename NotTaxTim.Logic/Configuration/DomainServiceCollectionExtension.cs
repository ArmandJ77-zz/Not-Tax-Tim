using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DOMAIN.Configuration
{
    public static class DomainServiceCollectionExtension
    {
        public static IServiceCollection AddDomain(this IServiceCollection container, IConfiguration config)
        {
            var settings = new DomainSettings();
            config.Bind(settings);

            container
                .AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationPipelineBehaviour<,>))
                ;

            return container;
        }
    }
}
