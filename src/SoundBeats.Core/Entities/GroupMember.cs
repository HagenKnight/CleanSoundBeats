using SoundBeats.Core.Entities.Base;

namespace SoundBeats.Core.Entities
{

    public class GroupMember : EntityBase<int>
    {
        public string Status { get; set; }
        public int JoinInYear { get; set; }
        public int LeftYear { get; set; }

        public int ArtistId { get; set; }
        public virtual Artist Artist { get; set; }

        public int MusicianId { get; set; }
        public virtual Musician Musician { get; set; }
    }
}
