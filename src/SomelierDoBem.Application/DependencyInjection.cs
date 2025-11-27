using Microsoft.Extensions.DependencyInjection;
using SomelierDoBem.Application.UseCases;

namespace SomelierDoBem.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<GetAllWinesUseCase>();
        services.AddScoped<GetWineByIdUseCase>();
        services.AddScoped<CreateWineUseCase>();
        services.AddScoped<UpdateWineUseCase>();
        services.AddScoped<DeleteWineUseCase>();
        return services;
    }
}
