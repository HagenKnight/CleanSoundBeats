using SoundBeats.Core.DTO;

namespace SoundBeats.Core.Interfaces.Services
{
    public interface ICountryService
    {
        Task<IEnumerable<CountryDTO>> GetCountries(CancellationToken cancellationToken = default);

        Task<CountryDTO> FindCountry(int id, CancellationToken cancellationToken = default);

        //Task<GenreDTO> FilterGenre(Expression<Func<Genre, bool>> predicate, CancellationToken cancellationToken = default);
    }
}
