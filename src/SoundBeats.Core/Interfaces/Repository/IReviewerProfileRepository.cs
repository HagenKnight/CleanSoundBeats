using SoundBeats.Core.Entities;

namespace SoundBeats.Core.Interfaces.Repository
{
    public interface IReviewerProfileRepository
    {
        Task<List<ReviewerProfile>> GetReviewerProfiles();
        Task<ReviewerProfile> GetReviewerProfile(int id);
        Task<ReviewerProfile> AddReviewerProfile(ReviewerProfile reviewerProfile);
        Task<ReviewerProfile> UpdateReviewerProfile(ReviewerProfile reviewerProfile);
        Task<ReviewerProfile> DeleteReviewerProfile(int id);
    }
}
