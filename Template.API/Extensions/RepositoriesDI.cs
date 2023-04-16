namespace Template.API.Extensions;

public static class RepositoriesDI
{
    /// <summary>
    /// Registers application repositories with the specified service collection.
    /// </summary>
    /// <param name="services"></param>
    public static void RegisterRepositories(this IServiceCollection services)
    {
        // READ operations
        services.AddScoped<IBaseGetRepository<TemplateEntity1>, BaseGetRepository<TemplateEntity1>>();

        // CRUD operations
        services.AddScoped<IBaseCRUDRepository<TemplateEntity2>, BaseCRUDRepository<TemplateEntity2>>();
    }
}