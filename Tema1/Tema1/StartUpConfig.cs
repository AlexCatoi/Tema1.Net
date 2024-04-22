using Microsoft.EntityFrameworkCore;
using Tema1.Core.Services;
using Tema1.Database.Context;
using Tema1.Database.Repositories;

namespace Tema1.API
{
    public static class StartupConfig
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<OrdersService>();
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddDbContext<Tema1DBContext>();
            services.AddScoped<DbContext, Tema1DBContext>();

            services.AddScoped<OrdersRepository>();
        }
    }
}
