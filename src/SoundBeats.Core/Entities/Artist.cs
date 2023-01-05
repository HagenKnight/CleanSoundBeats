using System.ComponentModel.DataAnnotations.Schema;

namespace SoundBeats.Core.Entities
{
    [Table("Artist")]
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
