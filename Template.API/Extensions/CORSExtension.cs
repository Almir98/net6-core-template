namespace Template.API.Extensions;

public static class CORSExtension
{
    /// <summary>
    /// Enables Cross-Origin Resource Sharing (CORS) for an ASP.NET Core web application.
    /// </summary>
    /// <param name="services">The service collection for the application.</param>
    public static void EnableCors(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("CORS", builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
            });
        });
    }
}