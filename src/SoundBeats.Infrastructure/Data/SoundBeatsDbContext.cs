using Microsoft.EntityFrameworkCore;
using SoundBeats.Core.Entities;

namespace SoundBeats.Infrastructure.Data
{
    public class SoundBeatsDbContext : DbContext
    {
        public SoundBeatsDbContext(DbContextOptions<SoundBeatsDbContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Musician> Musicians { get; set; }
        public DbSet<GroupMember> GroupMembers { get; set; }
        public DbSet<Album> Albums{ get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<ReviewerProfile> ReviewerProfiles { get; set; }
        public DbSet<SongReview> SongReviews { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SoundBeatsConfiguration());
        }

    }
}