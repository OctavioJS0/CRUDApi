using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Contexts;

namespace Persistence;

public static class DependencyContainer
{
    public static IServiceCollection AddPersistenceConfiguration(this IServiceCollection services,
        IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        return services.AddDbContext<CrudApiDbContext>(options =>
            options.UseSqlServer(connectionString,
                b => b.MigrationsAssembly(typeof(CrudApiDbContext).Assembly.FullName)));

        // #region Repositories
        // .AddTransient(typeof(IRepositoryAsync<>), typeof(MyRepositoryAsync<>))
        // .AddTransient(typeof(IReadRepositoryAsync<>), typeof(MyReadRepositoryAsync<>));
        // #endregion
    }
}