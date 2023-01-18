using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SoundBeats.Core.Entities;

namespace SoundBeats.Infrastructure.Data
{
    public class SoundBeatsDbContext : DbContext
    {
        public SoundBeatsDbContext() : base() { }
        public SoundBeatsDbContext(DbContextOptions<SoundBeatsDbContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Musician> Musicians { get; set; }
        public DbSet<GroupMember> GroupMembers { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<ReviewerProfile> ReviewerProfiles { get; set; }
        public DbSet<SongReview> SongReviews { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CountryConfiguration());

            // Singularize table name
            foreach (IMutableEntityType entity in modelBuilder.Model.GetEntityTypes())
            {
                if (entity.BaseType == null)
                {
                    entity.SetTableName(entity.DisplayName());
                }
            }
        }

    }
}