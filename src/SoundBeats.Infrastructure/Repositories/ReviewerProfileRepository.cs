using Microsoft.EntityFrameworkCore;
using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces;
using SoundBeats.Infrastructure.Data;

namespace SoundBeats.Infrastructure.Repositories
{
    public class ReviewerProfile : IReviewerProfileRepository
    {

        private readonly SoundBeatsDbContext _soundBeatsDbContext;
        public ReviewerProfile(SoundBeatsDbContext soundBeatsDbContext) => _soundBeatsDbContext= soundBeatsDbContext;

        public Task<Core.Entities.ReviewerProfile> AddReviewerProfile(Core.Entities.ReviewerProfile reviewerProfile)
        {
            throw new NotImplementedException();
        }

        public Task<Core.Entities.ReviewerProfile> DeleteReviewerProfile(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Core.Entities.ReviewerProfile> GetReviewerProfile(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Core.Entities.ReviewerProfile>> GetReviewerProfiles()
        {
            throw new NotImplementedException();
        }

        public Task<Core.Entities.ReviewerProfile> UpdateReviewerProfile(Core.Entities.ReviewerProfile reviewerProfile)
        {
            throw new NotImplementedException();
        }
    }
}
