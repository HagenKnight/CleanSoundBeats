using SoundBeats.Core.Entities;

namespace SoundBeats.Core.Interfaces.Repository
{
    public interface ISongRepository
    {
        Task<List<Song>> GetSongs();
        Task<Song> GetSong(int id);
        Task<Song> AddSong(Song song);
        Task<Song> UpdateSong(Song song);
        Task<Song> DeleteSong(int id);
    }
}
