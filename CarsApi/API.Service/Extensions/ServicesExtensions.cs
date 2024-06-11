using API.Service.Data.Repository;
using API.Service.Service;

namespace API.Service.Extensions
{
    //TODO: change
    public static class ServicesExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<CarService>();
            services.AddScoped<ManufactureRepository>();
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<CarRepository>();
            services.AddScoped<ManufactureRepository>();
        }
    }
}
