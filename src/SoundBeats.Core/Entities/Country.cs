using SoundBeats.Core.Entities.Base;

namespace SoundBeats.Core.Entities
{
    public class Country : EntityBase<int>
    {
        public string NameEs { get; set; }
        public string NameEn { get; set; }
        public string ISO2 { get; set; }
        public string ISO3 { get; set; }

        // Navigation property
        public ICollection<Artist>? Artist { get; set; }
    }
}
