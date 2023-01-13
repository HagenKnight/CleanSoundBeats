using Microsoft.Extensions.DependencyInjection;

namespace SoundBeats.Infrastructure.Extensions.ServiceCollections
{
    public static class ControllerConfigure
    {

        public static IServiceCollection AddControllerExtension(this IServiceCollection services)
        {
            services.AddControllers()
              .AddNewtonsoftJson(options =>
              {
                  options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
                  options.SerializerSettings.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
                  options.SerializerSettings.DateTimeZoneHandling = Newtonsoft.Json.DateTimeZoneHandling.Local;
                  options.UseCamelCasing(false);
              });

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            return services;
        }
    }
}
