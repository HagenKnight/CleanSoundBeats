using Microsoft.EntityFrameworkCore;
using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces;
using SoundBeats.Core.Interfaces.Base;
using SoundBeats.Core.Interfaces.Repository;
using SoundBeats.Infrastructure.Data;
using SoundBeats.Infrastructure.Persistence.Repository.Base;
using System.Linq.Expressions;
using System.Threading;

namespace SoundBeats.Infrastructure.Persistence.Repository
{
    public class GenreRepository : BaseRepository<Genre, int, SoundBeatsDbContext>, IGenreRepository<SoundBeatsDbContext>
    {
        public GenreRepository(IDbFactory<SoundBeatsDbContext> dbFactory) : base(dbFactory) { }

        public async Task<Genre> GetGenre(int id, CancellationToken cancellationToken = default) => 
            await GetByIdAsync(id, cancellationToken);

        public async Task<IEnumerable<Genre>> GetGenres(CancellationToken cancellationToken = default) => 
            await AllAsync(cancellationToken);

        public async Task<IEnumerable<Genre>> FilterGenre(Expression<Func<Genre, bool>> predicate, CancellationToken cancellationToken = default) =>
            await FilterAsync(predicate, cancellationToken);

        public async Task AddGenre(Genre genre, CancellationToken cancellationToken = default) => 
            await AddAsync(genre, cancellationToken);

        public void UpdateGenre(Genre genre) => 
            Update(genre);

        public void DeleteGenre(Genre genre) => 
            Delete(genre);
    }

}
