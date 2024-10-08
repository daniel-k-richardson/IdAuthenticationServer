using IdAuthenticationServer.Persistence.ContextConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IdAuthenticationServer.Persistence;

public static class PersistenceDependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<IdAuthContext>((sp, options) =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });

        services.AddScoped<IdAuthContext>(provider => provider.GetRequiredService<IdAuthContext>());
        // services.AddHostedService<DatabaseMigrationService>();

        return services;
    }
}
