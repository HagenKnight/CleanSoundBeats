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
    [Table("SongReview")]
    public class SongReview
    {
        public int Id { get; set; }
        public int Ranking { get; set; }
        public string Comment { get; set; }

        public int SongId { get; set; }
        public Song Song { get; set; }

        public int ReviewerProfileId { get; set; }
        public ReviewerProfile Artist { get; set; }
    }
}
