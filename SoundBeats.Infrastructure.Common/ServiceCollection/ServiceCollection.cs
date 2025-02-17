﻿using Microsoft.Extensions.DependencyInjection;
using SoundBeats.Core.Interfaces.Repository;
using SoundBeats.Core.Interfaces.Services;
using SoundBeats.Infrastructure.Common.Repositories;
using SoundBeats.Infrastructure.Common.Services;
using SoundBeats.Infrastructure.Persistence.Data;
using SoundBeats.Infrastructure.Persistence.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundBeats.Infrastructure.Common.ServiceCollection
{
    public static class ServiceCollection
    {
        public static void AddCommonLayer(this IServiceCollection services)
        {
            /* Repositories */
            services.AddTransient<IGenreRepository<SoundBeatsDbContext>, GenreRepository>();
            services.AddTransient<ICountryRepository<SoundBeatsDbContext>, CountryRepository>();
            services.AddTransient<IArtistRepository<SoundBeatsDbContext>, ArtistRepository>();

            /* Services */
            services.AddTransient<IGenreService, GenreService>();
            services.AddTransient<ICountryService, CountryService>();
            services.AddTransient<IArtistService, ArtistService>();

            /* Helpers */
        }
    }
}
