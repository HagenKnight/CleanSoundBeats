using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoundBeats.Core.Entities
{
    [Table("Genre")]
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Song> Songs { get; set; }
    }
}
