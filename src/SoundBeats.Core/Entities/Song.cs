using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SoundBeats.Core.Entities
{
    [Table("Song")]
    public class Song
    {
        public int Id { get; set; }
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
