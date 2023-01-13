using SoundBeats.Core.Entities.Base;

namespace SoundBeats.Core.Entities
{
    public class Album : EntityBase<int>
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string CoverUrl { get; set; }
        public string ImageType { get; set; }

        public int ArtistId { get; set; }
        public Artist Artist { get; set; }

        // navigation Property 
        public ICollection<Song> Song { get; set; }
    }
}
