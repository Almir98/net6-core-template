using Template.Domain.Persistance;

namespace Template.API.Extensions;

public static class DbContextConfiguration
{
    /// <summary>
    /// Adds database persistence to the application by configuring a database context.
    /// </summary>
    /// <param name="services">The service collection for the application.</param>
    /// <param name="configuration">The application configuration that contains the database connection string.</param>
    public static void AddPersistance(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<TemplateDbContext>(
            options => options.UseSqlServer(configuration.GetConnectionString("dbConnection")));
    }
}