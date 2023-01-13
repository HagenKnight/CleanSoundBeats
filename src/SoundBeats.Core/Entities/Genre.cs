using SoundBeats.Core.Entities.Base;

namespace SoundBeats.Core.Entities
{
    public class Genre : EntityBase<int>
    {
        public string Name { get; set; }

        // navigation property
        public ICollection<Song>? Songs { get; set; }
    }
}
