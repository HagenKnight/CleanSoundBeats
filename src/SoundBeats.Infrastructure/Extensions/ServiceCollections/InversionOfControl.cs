using Microsoft.Extensions.DependencyInjection;
using SoundBeats.Core.Interfaces.Base;
using SoundBeats.Core.Interfaces.Repository;
using SoundBeats.Core.Interfaces.Services;
using SoundBeats.Infrastructure.Data;
using SoundBeats.Infrastructure.Persistence.Base;
using SoundBeats.Infrastructure.Persistence.Repository;
using SoundBeats.Infrastructure.Persistence.Services;

namespace SoundBeats.Infrastructure.Extensions.ServiceCollections
{
    public static class InversionOfControl
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            // DbFactory and Unit of Work injection
            services.AddScoped<IDbFactory<SoundBeatsDbContext>, DbFactory<SoundBeatsDbContext>>();
            services.AddScoped<IUnitOfWork<SoundBeatsDbContext>, UnitOfWork<SoundBeatsDbContext>>();

            /*services.AddTransient<ICountryRepository, CountryRepository>();
            services.AddTransient<IArtistRepository, ArtistRepository>();
            services.AddTransient<IMusicianRepository, MusicianRepository>();
            services.AddTransient<IGroupMemberRepository, GroupMemberRepository>();
            services.AddTransient<IAlbumRepository, AlbumRepository>();*/
            services.AddTransient<IGenreRepository<SoundBeatsDbContext>, GenreRepository>();
            /*services.AddTransient<ISongRepository, SongRepository>();
            services.AddTransient<IReviewerProfileRepository, ReviewerProfile>();
            services.AddTransient<ISongReviewRepository, SongReviewRepository>();*/

            /* Services */
            services.AddTransient<IGenreService, GenreService>();

            return services;
        }
    }
}
