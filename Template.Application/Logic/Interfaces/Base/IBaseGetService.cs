namespace Template.Application.Logic.Interfaces;

public interface IBaseGetService<TModel> where TModel : class
{
    Task<List<TModel>> GetAllAsync();
    Task<TModel> GetByIdAsync(int id);
}