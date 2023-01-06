using Microsoft.EntityFrameworkCore;
using SoundBeats.Core.Entities;
using SoundBeats.Core.Interfaces;
using SoundBeats.Infrastructure.Data;

namespace SoundBeats.Infrastructure.Repositories
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
