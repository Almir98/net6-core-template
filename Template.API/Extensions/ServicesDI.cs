namespace Template.API.Extensions;

public static class ServicesDI
{
    /// <summary>
    /// Registers application services with the specified service collection.
    /// </summary>
    public static void RegisterServices(this IServiceCollection services)
    {
        // READ operations
        services.AddTransient<IBaseGetService<TemplateEntity1Dto>, BaseGetService<TemplateEntity1Dto>>();

        // CRUD operations
        //services.AddSingleton<IBaseCrudService<int, TemplateEntity2Dto, TemplateEntity2>, BaseCrudService<int, TemplateEntity2Dto, TemplateEntity2>>();
    }
}