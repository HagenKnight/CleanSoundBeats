using SoundBeats.Core.Entities.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoundBeats.Core.Entities
{
    public class Song : EntityBase<int>
    {
        public int TrackNumber { get; set; }
        public string Title { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Length { get; set; }
        public int AlbumId { get; set; }
        public virtual Album Album { get; set; }

        /* Relación 1 a 1*/
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }

        public ICollection<SongReview> SongReviews { get; set; }
    }
}
