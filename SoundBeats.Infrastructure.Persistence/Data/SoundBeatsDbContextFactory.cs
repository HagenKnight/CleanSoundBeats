using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBeats.Infrastructure.Persistence.Data
{
    public  class SoundBeatsDbContextFactory : IDesignTimeDbContextFactory<SoundBeatsDbContext>
    {

        public SoundBeatsDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

            var optionsBuilder = new DbContextOptionsBuilder<SoundBeatsDbContext>();
            string connectionString = configuration.GetConnectionString("SoundBeatsConnection");

            optionsBuilder.UseSqlServer(connectionString);

            return new SoundBeatsDbContext(optionsBuilder.Options);
        }
    }
}
