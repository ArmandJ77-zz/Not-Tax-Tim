using DATABASE.Configuration;
using DOMAIN.Configuration;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace API
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddCors()
                .AddControllers()
                .AddNewtonsoftJson()
                ;

            //            services
            //                .AddMvc(options => { options.Filters.Add<ValidationFilter>(); })
            //                .AddFluentValidation(config => config.RegisterValidatorsFromAssemblyContaining<CreateOrderValidator>())
            //                ;

            services
                .AddDatabase(_configuration.GetConnectionString("Database"))
                .AddDomain(_configuration)
                .AddMediatR(typeof(DomainServiceCollectionExtension).Assembly)
                ;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app
                .UseHttpsRedirection()
                .UseRouting()
                .UseAuthorization()
                .UseEndpoints(endpoints =>
                {
                    endpoints.MapControllers();
                })
                ;
        }
    }
}