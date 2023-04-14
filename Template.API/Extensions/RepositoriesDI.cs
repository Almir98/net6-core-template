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
            // READ operations
            services.AddSingleton<IBaseGetRepository<int, TemplateEntity1>, BaseGetRepository<int, TemplateEntity1, TemplateDbContext>>();

            // CRUD operations
            services.AddSingleton<IBaseCRUDRepository<int, TemplateEntity2>, BaseCRUDRepository<int, TemplateEntity2, TemplateDbContext>>();
        }
    }
}
