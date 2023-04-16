namespace Template.Application.Logic.Services;

public class BaseCrudService<TModel, TEntity> : BaseGetService<TModel, TEntity>, IBaseCrudService<TModel> where TModel : class where TEntity : class
{
    protected readonly IBaseCRUDRepository<TEntity> _baseCrudRepository;        // ?????

    public BaseCrudService(IBaseCRUDRepository<TEntity> baseCrudRepository, IMapper mapper) : base(baseCrudRepository, mapper)
    {
        _baseCrudRepository = baseCrudRepository;
    }


    //public BaseCrudService(IBaseGetRepository<TEntity> baseGetRepository, IMapper mapper, IBaseCRUDRepository<TEntity> baseCrudRepository) : base(baseGetRepository, mapper)
    //{
    //    _baseCrudRepository = baseCrudRepository;
    //}

    public async Task<TModel> Create(TModel model)
    {
        throw new NotImplementedException();

        //return await _baseCrudRepository.Create(_mapper.Map<TEntity>(model));
    }

    public async Task<TModel> Update(int id, TModel model)
    {
        throw new NotImplementedException();

        //return await _baseCrudRepository.Update(id, _mapper.Map<TEntity>(model));
    }

    public async Task Delete(int id)
    {
        throw new NotImplementedException();

        //await _baseCrudRepository.Delete(id);
    }
}