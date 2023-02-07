using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces.Repository;
using SoundBeats.Infrastructure.Persistence.Data;

namespace SoundBeats.Infrastructure.Common.Repositories
{
    public class GroupMemberRepository : IGroupMemberRepository
    {

        private readonly SoundBeatsDbContext _soundBeatsDbContext;
        public GroupMemberRepository(SoundBeatsDbContext soundBeatsDbContext) => _soundBeatsDbContext= soundBeatsDbContext;

        public Task<GroupMember> AddGroupMember(GroupMember groupMember)
        {
            throw new NotImplementedException();
        }

        public Task<GroupMember> DeleteGroupMember(int id)
        {
            throw new NotImplementedException();
        }

        public Task<GroupMember> GetGroupMember(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<GroupMember>> GetGroupMembers()
        {
            throw new NotImplementedException();
        }

        public Task<GroupMember> UpdateGroupMember(GroupMember groupMember)
        {
            throw new NotImplementedException();
        }
    }
}
