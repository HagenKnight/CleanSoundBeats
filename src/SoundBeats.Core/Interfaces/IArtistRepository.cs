using SoundBeats.Core.Entities;

namespace SoundBeats.Core.Interfaces
{
    public interface IArtistRepository
    {
        Task<List<Artist>> GetArtists();
        Task<Artist> GetArtist(int id);
        Task<Artist> AddArtist(Artist artist);
        Task<Artist> UpdateArtist(Artist artist);
        Task<Artist> DeleteArtist(int id);
    }
}
