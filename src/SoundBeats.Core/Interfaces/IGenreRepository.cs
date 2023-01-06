using SoundBeats.Core.Entities;

namespace SoundBeats.Core.Interfaces
{
    public interface IGenreRepository
    {
        Task<List<Genre>> GetGenres();
        Task<Genre> GetGenre(int id);
        Task<Genre> AddGenre(Genre genre);
        Task<Genre> UpdateGenre(Genre genre);
        Task<Genre> DeleteGenre(int id);
    }
}
