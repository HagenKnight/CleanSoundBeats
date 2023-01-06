using Microsoft.EntityFrameworkCore;
using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces;
using SoundBeats.Infrastructure.Data;

namespace SoundBeats.Infrastructure.Repositories
{
    public class ArtistRepository : IArtistRepository
    {

        private readonly SoundBeatsDbContext _soundBeatsDbContext;
        public ArtistRepository(SoundBeatsDbContext soundBeatsDbContext) => _soundBeatsDbContext= soundBeatsDbContext;

        public async Task<Artist> GetArtist(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Artist>> GetArtists()
        {
            throw new NotImplementedException();
        }

        public async Task<Artist> AddArtist(Artist artist)
        {
            throw new NotImplementedException();
        }

        public async Task<Artist> UpdateArtist(Artist artist)
        {
            throw new NotImplementedException();
        }

        public async Task<Artist> DeleteArtist(int id)
        {
            throw new NotImplementedException();
        }
    }
}
