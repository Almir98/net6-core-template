namespace Template.API.Extensions
{
    public static class ServicesDI
    {
        /// <summary>
        /// Registers application services with the specified service collection.
        /// </summary>
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<object, object>();

        }
    }
}
