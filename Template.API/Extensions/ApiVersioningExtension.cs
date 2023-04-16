namespace Template.API.Extensions;

public static class ApiVersioningExtension
{
    /// <summary>
    /// Adds API versioning support to the application by configuring the default version and other options.
    /// </summary>
    /// <param name="services">The service collection for the application.</param>
    public static void AddAppVersioning(this IServiceCollection services)
    {
        services.AddApiVersioning(config =>
        {
            config.DefaultApiVersion = new ApiVersion(1, 0);
            config.AssumeDefaultVersionWhenUnspecified = true;
            config.ReportApiVersions = true;
        });
    }
}