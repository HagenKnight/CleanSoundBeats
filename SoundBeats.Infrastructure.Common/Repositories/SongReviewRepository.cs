using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces.Repository;
using SoundBeats.Infrastructure.Persistence.Data;

namespace SoundBeats.Infrastructure.Common.Repositories
{
    public class SongReviewRepository : ISongReviewRepository
    {

        private readonly SoundBeatsDbContext _soundBeatsDbContext;
        public SongReviewRepository(SoundBeatsDbContext soundBeatsDbContext) => _soundBeatsDbContext= soundBeatsDbContext;

        public Task<SongReview> AddSongReview(SongReview songReview)
        {
            throw new NotImplementedException();
        }

        public Task<SongReview> DeleteSongReview(int id)
        {
            throw new NotImplementedException();
        }

        public Task<SongReview> GetSongReview(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SongReview>> GetSongReviews()
        {
            throw new NotImplementedException();
        }

        public Task<SongReview> UpdateSongReview(SongReview songReview)
        {
            throw new NotImplementedException();
        }
    }
}
