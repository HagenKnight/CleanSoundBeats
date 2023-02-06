using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SoundBeats.Infrastructure.Extensions.ServiceCollections
{
    public static class DatabaseContext
    {
        public static IServiceCollection AddDbContextsREE(this IServiceCollection services, IConfiguration configuration)
        {
            /*services.AddDbContext<SoundBeatsDbContext>(options => {
                // Add the DbConnector for your project
                options.UseSqlServer(configuration.GetConnectionString("SoundBeatsConnection"));
            });*/
            return services;
        }
    }
}
