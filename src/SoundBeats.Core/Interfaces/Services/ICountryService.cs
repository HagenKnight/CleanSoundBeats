using SoundBeats.Core.DTO;
using SoundBeats.Core.Entities;
using SoundBeats.Core.Entities.Base;
using System.Linq.Expressions;

namespace SoundBeats.Core.Interfaces.Services
{
    public interface ICountryService
    {
        public int RowCount { get; }
        Task<IEnumerable<ShapedEntityDTO>> GetCountries(CancellationToken cancellationToken = default, string fields = null, string orderBy = null);
        Task<IEnumerable<ShapedEntityDTO>> GetPagedCountries(int pageNumber, int pageSize, CancellationToken cancellationToken = default, Expression<Func<Country, bool>> predicate = null, string fields = null, string orderBy = null);

        Task<CountryDTO> FindCountry(int id, CancellationToken cancellationToken = default);

        //Task<GenreDTO> FilterGenre(Expression<Func<Genre, bool>> predicate, CancellationToken cancellationToken = default);
    }
}
