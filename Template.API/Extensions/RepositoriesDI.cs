namespace Template.API.Extensions
{
    public static class RepositoriesDI
    {
        /// <summary>
        /// Registers application repositories with the specified service collection.
        /// </summary>
        /// <param name="services"></param>
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<object, object>();

        }
    }
}
