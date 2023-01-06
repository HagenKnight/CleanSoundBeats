using SoundBeats.Core.Entities;

namespace SoundBeats.Core.Interfaces
{
    public interface IGroupMemberRepository
    {
        Task<List<GroupMember>> GetGroupMembers();
        Task<GroupMember> GetGroupMember(int id);
        Task<GroupMember> AddGroupMember(GroupMember groupMember);
        Task<GroupMember> UpdateGroupMember(GroupMember groupMember);
        Task<GroupMember> DeleteGroupMember(int id);
    }
}
