using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces.Base;
using SoundBeats.Core.Interfaces.Repository;
using SoundBeats.Infrastructure.Persistence.Data;
using SoundBeats.Infrastructure.Persistence.Repository.Base;
using System.Linq.Expressions;
using System.Threading;

namespace SoundBeats.Infrastructure.Common.Repositories
{
    public class ArtistRepository : BaseRepository<Artist, int, SoundBeatsDbContext>, IArtistRepository<SoundBeatsDbContext>
    {

        private readonly SoundBeatsDbContext _soundBeatsDbContext;
        public ArtistRepository(IDbFactory<SoundBeatsDbContext> dbFactory) : base(dbFactory) { }


        public async Task<IEnumerable<Artist>> GetArtists(CancellationToken cancellationToken = default) =>
            await AllAsync(cancellationToken);

        public async Task<Artist> GetArtist(int id, CancellationToken cancellationToken = default) =>
            await GetByIdAsync(id, cancellationToken);

        public async Task<IEnumerable<Artist>> FilterArtist(Expression<Func<Artist, bool>> predicate, CancellationToken cancellationToken = default) =>
            await FilterAsync(predicate, cancellationToken);

        public async Task AddArtist(Artist artist, CancellationToken cancellationToken = default) =>
            await AddAsync(artist, cancellationToken);

        public void UpdateArtist(Artist artist) =>
            Update(artist);

        public void DeleteArtist(Artist artist) =>
            Delete(artist);
    }
}
