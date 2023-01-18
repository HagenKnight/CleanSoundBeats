namespace SoundBeats.Core.DTO.Song
{
    public class SongDTO
    {
        public int Id { get; set; }
        public int TrackNumber { get; set; }
        public string Title { get; set; }
        public decimal Length { get; set; }
        public int AlbumId { get; set; }
        public int GenreId { get; set; }
    }
}
