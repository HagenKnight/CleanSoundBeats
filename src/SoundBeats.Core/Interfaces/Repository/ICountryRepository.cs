using Microsoft.EntityFrameworkCore;
using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces.Base;
using System.Linq.Expressions;

namespace SoundBeats.Core.Interfaces.Repository
{
    public interface ICountryRepository<TContext> : IBaseRepository<Country, TContext> where TContext : DbContext, new()
    {
        Task<IEnumerable<Country>> GetCountries(CancellationToken cancellationToken = default);
        Task<IEnumerable<Country>> GetPagedCountries(int pageNumber, int pageSize, CancellationToken cancellationToken = default);
        Task<Country> GetCountry(int id, CancellationToken cancellationToken = default);
        Task<IEnumerable<Country>> FilterCountry(Expression<Func<Country, bool>> predicate, CancellationToken cancellationToken = default);

    }
}
