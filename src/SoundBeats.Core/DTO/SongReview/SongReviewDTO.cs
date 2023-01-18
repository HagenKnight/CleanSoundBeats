namespace SoundBeats.Core.DTO.SongReview
{
    public class SongReviewDTO
    {
        public int Id { get; set; }
        public int Ranking { get; set; }
        public string Comment { get; set; }
        public int SongId { get; set; }
        public int ReviewerProfileId { get; set; }
    }
}
