namespace Template.Application.Logic.Interfaces;

public interface IBaseCrudService<TModel> : IBaseGetService<TModel> where TModel : class
{
    Task<TModel> Create(TModel model);

    Task<TModel> Update(int id, TModel model);

    Task Delete(int id);
}