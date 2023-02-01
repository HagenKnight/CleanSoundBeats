using SoundBeats.Core.Entities;

namespace SoundBeats.Core.Interfaces.Repository
{
    public interface ICountryRepository
    {
        Task<List<Country>> GetCountries();
        Task<Country> GetCountry(int id);
    }
}
