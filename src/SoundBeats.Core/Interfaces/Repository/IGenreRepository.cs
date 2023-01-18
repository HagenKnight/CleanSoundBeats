using Microsoft.EntityFrameworkCore;
using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces.Base;
using System.Linq.Expressions;

namespace SoundBeats.Core.Interfaces.Repository
{
    public interface IGenreRepository<TContext> : IBaseRepository<Genre, TContext> where TContext : DbContext, new()
    {
        Task<IEnumerable<Genre>> GetGenres(CancellationToken cancellationToken = default);
        Task<Genre> GetGenre(int id, CancellationToken cancellationToken = default);
        Task<IEnumerable<Genre>> FilterGenre(Expression<Func<Genre, bool>> predicate, CancellationToken cancellationToken = default);
        
        Task AddGenre(Genre genre, CancellationToken cancellationToken = default);

        void UpdateGenre(Genre genre);
        void DeleteGenre(Genre genre);
    }
}
