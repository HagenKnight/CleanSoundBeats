using SoundBeats.Core.Entities.Base;

namespace SoundBeats.Core.Entities
{
    public class Musician : EntityBase<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthPlace { get; set; }
        public string ImageUrl { get; set; }
        public string ImageType { get; set; }

        // Navigation Property
        public ICollection<GroupMember>? GroupMember { get; set; }
    }
}
