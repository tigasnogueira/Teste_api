using Teste.Data.Context;
using Teste.Data.Repository;
using Teste.Domain.Interfaces;
using Teste.Service.Services;

namespace Teste.API.Config
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependences(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IContaService, ContaService>();
            services.AddScoped<IContaRepository, ContaRepository>();

            return services;
        }
    }
}
