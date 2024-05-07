using Asp.Versioning;
using Microsoft.Extensions.DependencyInjection;

namespace Controllers;

public static class DependencyContainer 
{
    public static IApiVersioningBuilder AddControllersConfigurations(this IServiceCollection services)
    {
        services.AddControllers();
        return services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
            }
        );
    }
}