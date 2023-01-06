using Microsoft.EntityFrameworkCore;
using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces;
using SoundBeats.Infrastructure.Data;

namespace SoundBeats.Infrastructure.Repositories
{
    public class GenreRepository : IGenreRepository
    {

        private readonly SoundBeatsDbContext _soundBeatsDbContext;
        public GenreRepository(SoundBeatsDbContext soundBeatsDbContext) => _soundBeatsDbContext= soundBeatsDbContext;


        public async Task<Genre> GetGenre(int id)
        {
            var _genre = await _soundBeatsDbContext.Genres.FirstOrDefaultAsync(x => x.Id == id);
            return _genre;
        }

        public async Task<List<Genre>> GetGenres()
        {
            var _genre = await _soundBeatsDbContext.Genres.ToListAsync();
            return _genre;
        }

        public Task<Genre> AddGenre(Genre genre)
        {
            throw new NotImplementedException();
        }

        public Task<Genre> UpdateGenre(Genre genre)
        {
            throw new NotImplementedException();
        }
        public Task<Genre> DeleteGenre(int id)
        {
            throw new NotImplementedException();
        }
    }
}
