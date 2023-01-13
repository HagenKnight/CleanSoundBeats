using SoundBeats.Core.Entities.Base;

namespace SoundBeats.Core.Entities
{
    public class ReviewerProfile : EntityBase<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Navigation Property
        public ICollection<SongReview> SongReviews { get; set; }
    }
}
