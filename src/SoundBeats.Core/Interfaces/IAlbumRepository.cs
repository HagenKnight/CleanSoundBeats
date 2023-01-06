using SoundBeats.Core.Entities;

namespace SoundBeats.Core.Interfaces
{
    public interface IAlbumRepository
    {
        Task<List<Album>> GetAlbums();
        Task<Album> GetAlbum(int id);
        Task<Album> AddAlbum(Album album);
        Task<Album> UpdateAlbum(Album album);
        Task<Album> DeleteAlbum(int id);
    }
}
