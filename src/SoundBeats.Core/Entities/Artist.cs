using SoundBeats.Core.Entities.Base;

namespace SoundBeats.Core.Entities
{
    public class Artist : EntityBase<int>
    {
        public string Name { get; set; }
        public string Biography { get; set; }

        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
    }
}
