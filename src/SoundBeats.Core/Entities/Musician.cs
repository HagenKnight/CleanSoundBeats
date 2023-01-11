using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoundBeats.Core.Entities
{
    [Table("Musician")]
    public class Musician
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string ImageUrl { get; set; }
        public string ImageType { get; set; }

        public ICollection<GroupMember>? GroupMember { get; set; }
    }
}
