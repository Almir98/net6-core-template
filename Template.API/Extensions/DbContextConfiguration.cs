using Microsoft.EntityFrameworkCore;
using Template.Database.DbContext;

namespace Template.API.Extensions
{
    public static class DbContextConfiguration
    {
        public static void AddPersistance(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TemplateDbContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("dbConnection")));
        }
    }
}
