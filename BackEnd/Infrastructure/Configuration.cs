using Application.Databases.Relational;
using Infrastructure.Databases.Relational.MsSql;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class Configuration
    {
        public static IServiceCollection InfrastructureConfiguration
            (
            this IServiceCollection serviceCollection,
            IConfiguration configuration
            )
        {
            serviceCollection.AddSingleton<IConfiguration>(configuration);
            serviceCollection.AddTransient<CmsDbContext, CmsMssqlDbContext>();

            return serviceCollection;
        }
    }
}
