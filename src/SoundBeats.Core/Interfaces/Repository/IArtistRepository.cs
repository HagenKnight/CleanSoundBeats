using Microsoft.EntityFrameworkCore;
using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces.Base;
using System.Linq.Expressions;

namespace SoundBeats.Core.Interfaces.Repository
{
    public interface IArtistRepository<TContext> : IBaseRepository<Artist, TContext> where TContext : DbContext, new()
    {
        Task<IEnumerable<Artist>> GetArtists(CancellationToken cancellationToken = default);
        Task<Artist> GetArtist(int id, CancellationToken cancellationToken = default);
        Task<IEnumerable<Artist>> FilterArtist(Expression<Func<Artist, bool>> predicate, CancellationToken cancellationToken = default);

        Task AddArtist(Artist artist, CancellationToken cancellationToken = default);

        void UpdateArtist(Artist artist);
        void DeleteArtist(Artist artist);
    }
}
