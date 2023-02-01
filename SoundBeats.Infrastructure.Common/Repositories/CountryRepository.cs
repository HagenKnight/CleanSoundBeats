using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces.Base;
using SoundBeats.Core.Interfaces.Repository;
using SoundBeats.Infrastructure.Persistence.Data;
using SoundBeats.Infrastructure.Persistence.Repository.Base;
using System.Linq.Expressions;

namespace SoundBeats.Infrastructure.Common.Repositories
{
    public class CountryRepository : BaseRepository<Country, int, SoundBeatsDbContext>, ICountryRepository<SoundBeatsDbContext>
    {

        public CountryRepository(IDbFactory<SoundBeatsDbContext> dbFactory) : base(dbFactory) { }

        public async Task<IEnumerable<Country>> GetCountries(CancellationToken cancellationToken = default) =>
           await AllAsync(cancellationToken);

        public async Task<Country> GetCountry(int id, CancellationToken cancellationToken = default) =>
            await GetByIdAsync(id, cancellationToken);

        public async Task<IEnumerable<Country>> FilterCountry(Expression<Func<Country, bool>> predicate, CancellationToken cancellationToken = default) =>
            await FilterAsync(predicate, cancellationToken);

    }
}
