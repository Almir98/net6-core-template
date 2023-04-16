namespace Template.Application.Logic.Services;

public class BaseCrudService<TModel> : BaseGetService<TModel>, IBaseCrudService<TModel> where TModel : class
{
    protected readonly IBaseCRUDRepository<TModel> _baseCrudRepository;

    public BaseCrudService(IBaseCRUDRepository<TModel> baseCrudRepository) : base(baseCrudRepository)
    {
        _baseCrudRepository = baseCrudRepository;
    }

    public async Task<TModel> Create(TModel model)
    {
        return await _baseCrudRepository.Create(model);
    }

    public async Task<TModel> Update(int id, TModel model)
    {
        return await _baseCrudRepository.Update(id, model);
    }

    public async Task Delete(int id)
    {
        await _baseCrudRepository.Delete(id);
    }
}