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
        services.AddScoped<IBaseGetRepository<TemplateEntity2Dto>, BaseGetRepository<TemplateEntity2Dto, TemplateEntity2>>();

        // CRUD operations
        services.AddScoped<IBaseCRUDRepository<TemplateEntity2Dto>, BaseCRUDRepository<TemplateEntity2Dto, TemplateEntity2>>();
    }
}