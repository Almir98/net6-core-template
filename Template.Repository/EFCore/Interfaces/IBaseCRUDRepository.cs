namespace Template.Service.Interfaces;

public interface IBaseCRUDRepository<TModel> : IBaseGetRepository<TModel> where TModel : class
{
    Task<TModel> Create(TModel model);
    Task<TModel> Update(int id, TModel model);
    Task Delete(int id);
}