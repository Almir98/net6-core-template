using Template.Application.Logic.Interfaces;

namespace Template.API.Extensions
{
    public static class ServicesDI
    {
        /// <summary>
        /// Registers application services with the specified service collection.
        /// </summary>
        public static void RegisterServices(this IServiceCollection services)
        {
            // READ operations
            services.AddSingleton<IBaseGetService<int, TemplateEntity1Dto>, BaseGetService<int, TemplateEntity1Dto>>();

            // CRUD operations
            //services.AddSingleton<IBaseCrudService<int, TemplateEntity2Dto, TemplateEntity2>, BaseCrudService<int, TemplateEntity2Dto, TemplateEntity2>>();
        }
    }
}
