using Microsoft.EntityFrameworkCore;
using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces;
using SoundBeats.Infrastructure.Data;

namespace SoundBeats.Infrastructure.Repositories
{
    public class CountryRepository : ICountryRepository
    {

        private readonly SoundBeatsDbContext _soundBeatsDbContext;
        public CountryRepository(SoundBeatsDbContext soundBeatsDbContext) => _soundBeatsDbContext= soundBeatsDbContext;

        public async Task<Country> GetCountry(int id)
        {
            var _country = await _soundBeatsDbContext.Countries.FirstOrDefaultAsync(x => x.Id == id);
            return _country;
        }

        public async Task<List<Country>> GetCountries()
        {
            var _genre = await _soundBeatsDbContext.Countries.ToListAsync();
            return _genre;
        }
    }
}
