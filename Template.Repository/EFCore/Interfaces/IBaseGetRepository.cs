namespace Template.Service.Interfaces;

public interface IBaseGetRepository<TModel> where TModel : class
{
    Task<List<TModel>> GetAll();
    Task<TModel> GetById(int id);
}