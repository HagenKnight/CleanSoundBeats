using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces;
using SoundBeats.Infrastructure.Persistence.Data;

namespace SoundBeats.Infrastructure.Common.Repositories
{
    public class SongRepository : ISongRepository
    {

        private readonly SoundBeatsDbContext _soundBeatsDbContext;
        public SongRepository(SoundBeatsDbContext soundBeatsDbContext) => _soundBeatsDbContext= soundBeatsDbContext;

        public Task<Song> AddSong(Song song)
        {
            throw new NotImplementedException();
        }

        public Task<Song> DeleteSong(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Song> GetSong(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Song>> GetSongs()
        {
            throw new NotImplementedException();
        }

        public Task<Song> UpdateSong(Song song)
        {
            throw new NotImplementedException();
        }
    }
}
