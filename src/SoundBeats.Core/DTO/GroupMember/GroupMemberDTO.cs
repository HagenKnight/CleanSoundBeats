namespace SoundBeats.Core.DTO.GroupMember
{
    public class GroupMemberDTO
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int JoinInYear { get; set; }
        public int LeftYear { get; set; }

        public int ArtistId { get; set; }
        public int MusicianId { get; set; }
    }
}
