using Microsoft.Extensions.DependencyInjection;
using SoundBeats.Core.Interfaces;
using SoundBeats.Infrastructure.Repositories;

namespace SoundBeats.Infrastructure.Extensions.ServiceCollections
{
    public static class InversionOfControl
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            services.AddTransient<ICountryRepository, CountryRepository>();
            services.AddTransient<IArtistRepository, ArtistRepository>();
            services.AddTransient<IMusicianRepository, MusicianRepository>();
            services.AddTransient<IGroupMemberRepository, GroupMemberRepository>();
            services.AddTransient<IAlbumRepository, AlbumRepository>();
            services.AddTransient<IGenreRepository, GenreRepository>();
            services.AddTransient<ISongRepository, SongRepository>();
            services.AddTransient<IReviewerProfileRepository, ReviewerProfile>();
            services.AddTransient<ISongReviewRepository, SongReviewRepository>();
            return services;
        }
    }
}
