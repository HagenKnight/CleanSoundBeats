using Microsoft.Extensions.DependencyInjection;

namespace SoundBeats.Infrastructure.Extensions.ServiceCollections
{
    public static class DbContextFactory
    {

        public static IServiceCollection AddDbFactoryREE(this IServiceCollection services)
        {
            // services.AddScoped<Func<SoundBeatsDbContext>>((provider) => () => provider.GetService<SoundBeatsDbContext>());

            // Factory Pattern implementations associated to DabaBase Context.
            return services;
        }
    }
}
