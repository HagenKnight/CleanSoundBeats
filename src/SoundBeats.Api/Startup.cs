using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using SoundBeats.Core.Mappings;
using SoundBeats.Infrastructure.Extensions.ServiceCollections;
using SoundBeats.Infrastructure.Extensions.ApplicationBuilder;

namespace SoundBeats.Api
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup).Assembly, typeof(AutoMapperProfile).Assembly);

            ControllerConfigure.AddControllerExtension(services);

            /* connection string to DBContext */
            DatabaseContext.AddDbContexts(services, Configuration);

            /* Inversion of Control container*/
            InversionOfControl.AddDependency(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            DefaultConfiguration.InitConfigurationAPI(app, env);
        }

    }
}
