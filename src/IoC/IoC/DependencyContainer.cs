using Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence;

namespace IoC;

public static class DependencyContainer
{
     public static void RegisterDependencyConfiguration(this IServiceCollection serviceCollection, IConfiguration configuration)
     {
          serviceCollection.AddPersistenceConfiguration(configuration);
          serviceCollection.AddControllersConfigurations();
     }
}