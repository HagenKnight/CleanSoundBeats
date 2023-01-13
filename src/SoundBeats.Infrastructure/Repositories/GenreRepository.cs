using Microsoft.EntityFrameworkCore;
using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces;
using SoundBeats.Infrastructure.Data;

namespace SoundBeats.Infrastructure.Repositories
{
    public class GenreRepository : IGenreRepository
    {

        private readonly SoundBeatsDbContext _soundBeatsDbContext;
        public GenreRepository(SoundBeatsDbContext soundBeatsDbContext) => _soundBeatsDbContext = soundBeatsDbContext;


        public async Task<Genre> GetGenre(int id)
        {
            try
            {
                var _genre = await _soundBeatsDbContext.Genres.FirstOrDefaultAsync(x => x.Id == id);
                return _genre;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<Genre>> GetGenres()
        {
            try
            {
                var _genre = await _soundBeatsDbContext.Genres.ToListAsync();
                return _genre;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Genre> AddGenre(Genre genre)
        {
            await _soundBeatsDbContext.Genres.AddAsync(genre);
            await _soundBeatsDbContext.SaveChangesAsync();
            return genre;
        }

        public async Task<Genre> UpdateGenre(Genre genre)
        {
            _soundBeatsDbContext.Entry(genre).State = EntityState.Modified;

            try
            {
                _soundBeatsDbContext.Genres.Update(genre);
                await _soundBeatsDbContext.SaveChangesAsync();
                return genre;
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }
        }

        public async Task<Genre> DeleteGenre(int id)
        {
            try
            {
                var genre = GetGenreById(id);
                if (genre == null)
                {
                    return null;
                }

                _soundBeatsDbContext.Genres.Remove(genre);
                await _soundBeatsDbContext.SaveChangesAsync();
                return genre;
            }
            catch (Exception)
            {

                throw new NotImplementedException();
            }
        }

        private bool GenreExists(int id)
        {
            return (_soundBeatsDbContext.Genres?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        private Genre GetGenreById(int id)
        {
            Genre? _genre = _soundBeatsDbContext.Genres.FirstOrDefault(x => x.Id == id);
            return _genre;
        }
    }
}
