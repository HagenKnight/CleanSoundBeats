using Microsoft.Extensions.DependencyInjection;
using SoundBeats.Infrastructure.Data;

namespace SoundBeats.Infrastructure.Extensions.ServiceCollections
{
    public static class DbContextFactory
    {

        public static IServiceCollection AddDbFactory(this IServiceCollection services)
        {
            services.AddScoped<Func<SoundBeatsDbContext>>((provider) => () => provider.GetService<SoundBeatsDbContext>());

            // Factory Pattern implementations associated to DabaBase Context.
            return services;
        }
    }
}
