using Microsoft.Extensions.DependencyInjection;
using SoundBeats.Core.Interfaces.Base;
using SoundBeats.Infrastructure.Persistence.Data;
using SoundBeats.Infrastructure.UnitOfWork.Base;


namespace SoundBeats.Infrastructure.UnitOfWork.ServiceCollection
{
    public static class ServiceExtension
    {
        public static void AddUnitOfWorkLayer(this IServiceCollection services)
        {
            /* Factory & Unit Of Work. */
            services.AddScoped<IDbFactory<SoundBeatsDbContext>, DbFactory<SoundBeatsDbContext>>();
            services.AddScoped<IUnitOfWork<SoundBeatsDbContext>, UnitOfWork<SoundBeatsDbContext>>();
        }
    }
}
