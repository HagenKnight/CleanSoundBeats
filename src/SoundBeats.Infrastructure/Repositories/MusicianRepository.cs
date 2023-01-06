using Microsoft.EntityFrameworkCore;
using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces;
using SoundBeats.Infrastructure.Data;

namespace SoundBeats.Infrastructure.Repositories
{
    public class MusicianRepository : IMusicianRepository
    {

        private readonly SoundBeatsDbContext _soundBeatsDbContext;
        public MusicianRepository(SoundBeatsDbContext soundBeatsDbContext) => _soundBeatsDbContext= soundBeatsDbContext;

        public Task<Musician> DeleteMusician(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Musician> GetMusician(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Musician>> GetMusicians()
        {
            throw new NotImplementedException();
        }

        public Task<Musician> InsertMusician(Musician genre)
        {
            throw new NotImplementedException();
        }

        public Task<Musician> UpdateMusician(Musician genre)
        {
            throw new NotImplementedException();
        }
    }
}
