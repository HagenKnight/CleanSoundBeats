namespace SoundBeats.Core.DTO.Musician
{
    public class MusicianDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string ImageUrl { get; set; }
        public string ImageType { get; set; }
    }
}
