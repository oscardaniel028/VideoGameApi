using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VideoGameApi.Data.Context;

namespace VideoGameApi.Infrestructure.Configurations
{
    public static class DbConnectionConfig
    {
        public static IServiceCollection AddDataBase(this IServiceCollection services, string connectionString) 
        {
            services.AddDbContext<VideoGameDbContext>(options =>
                options.UseSqlServer(connectionString));
            return services;
        }

    }
}
