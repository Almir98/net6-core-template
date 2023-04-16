namespace Template.Application.Logic.Services;

public class BaseCrudService<TModel> : BaseGetService<TModel>, IBaseCrudService<TModel> where TModel : class
{
    protected readonly IBaseCRUDRepository<TModel> _baseCrudRepository;        // ?????

    //public BaseCrudService(IBaseCRUDRepository<TModel> baseCrudRepository, IMapper mapper) : base(baseCrudRepository, mapper)
    //    _baseCrudRepository = baseCrudRepository;
    //}

    public BaseCrudService(IBaseCRUDRepository<TModel> baseCrudRepository) : base(baseCrudRepository)
    {
        _baseCrudRepository = baseCrudRepository;
    }

    public async Task<TModel> Create(TModel model)
    {
        return await _baseCrudRepository.Create(model);

        //var response = await _baseCrudRepository.Create(model);

        //return _mapper.Map<TModel>(response);
    }

    public async Task<TModel> Update(int id, TModel model)
    {
        return await _baseCrudRepository.Update(id, model);

        //var response = await _baseCrudRepository.Update(id, _mapper.Map<TEntity>(model));

        //var response = await _baseCrudRepository.Update(id, model);

        //return _mapper.Map<TModel>(response);
    }

    public async Task Delete(int id)
    {
        await _baseCrudRepository.Delete(id);
    }
}