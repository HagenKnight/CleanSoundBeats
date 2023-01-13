using SoundBeats.Core.Entities.Base;

namespace SoundBeats.Core.Entities
{
    public class SongReview : EntityBase<int>
    {
        public int Ranking { get; set; }
        public string Comment { get; set; }

        public int SongId { get; set; }
        public Song Song { get; set; }

        public int ReviewerProfileId { get; set; }
        public ReviewerProfile Artist { get; set; }
    }
}
