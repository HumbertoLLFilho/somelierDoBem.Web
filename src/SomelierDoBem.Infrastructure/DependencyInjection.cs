using Microsoft.Extensions.DependencyInjection;
using SomelierDoBem.Domain.Interfaces;
using SomelierDoBem.Infrastructure.Persistence;

namespace SomelierDoBem.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IWineRepository, InMemoryWineRepository>();
        return services;
    }
}
