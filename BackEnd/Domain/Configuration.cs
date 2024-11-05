using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Domain
{
    public static class Configuration
    {
        public static IServiceCollection DomainConfiguration
            (
            this IServiceCollection serviceCollection,
            IConfiguration configuration
            )
        {
            serviceCollection.AddSingleton<IConfiguration>(configuration);

            return serviceCollection;
        }
    }
}
