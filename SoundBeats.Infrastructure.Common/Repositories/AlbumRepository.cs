using Microsoft.EntityFrameworkCore;
using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces.Repository;
using SoundBeats.Infrastructure.Persistence.Data;

namespace SoundBeats.Infrastructure.Common.Repositories
{
    public class AlbumRepository : IAlbumRepository
    {

        private readonly SoundBeatsDbContext _soundBeatsDbContext;
        public AlbumRepository(SoundBeatsDbContext soundBeatsDbContext) => _soundBeatsDbContext = soundBeatsDbContext;

        public async Task<Album> GetAlbum(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Album>> GetAlbums()
        {
            throw new NotImplementedException();
        }

        public async Task<Album> AddAlbum(Album artist)
        {
            throw new NotImplementedException();
        }

        public async Task<Album> UpdateAlbum(Album artist)
        {
            throw new NotImplementedException();
        }

        public async Task<Album> DeleteAlbum(int id)
        {
            throw new NotImplementedException();
        }
    }
}
