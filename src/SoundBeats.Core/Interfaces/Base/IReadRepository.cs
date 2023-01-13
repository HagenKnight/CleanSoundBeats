using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace SoundBeats.Core.Interfaces.Base
{
    public interface IReadRepository<T, TContext> where T : class where TContext : DbContext, new()
    {
        Task<IEnumerable<T>> AllAsync(CancellationToken cancellationToken = default);
        Task<T> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<IEnumerable<T>> FilterAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);
    }
}
