using Microsoft.AspNetCore.Mvc;

namespace Template.API.Extensions
{
    public static class ApiVersioningExtension
    {
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
}
