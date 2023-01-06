using SoundBeats.Core.Entities;

namespace SoundBeats.Core.Interfaces
{
    public interface ISongReviewRepository
    {
        Task<List<SongReview>> GetSongReviews();
        Task<SongReview> GetSongReview(int id);
        Task<SongReview> AddSongReview(SongReview songReview);
        Task<SongReview> UpdateSongReview(SongReview songReview);
        Task<SongReview> DeleteSongReview(int id);
    }
}
