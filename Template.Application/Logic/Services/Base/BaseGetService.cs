namespace Template.Application.Logic.Services;

public class BaseGetService<TModel, TEntity> : IBaseGetService<TModel> where TModel : class where TEntity : class
{
    protected readonly IBaseGetRepository<TEntity> _baseGetRepository;
    protected  readonly  IMapper _mapper;

    public BaseGetService(IBaseGetRepository<TEntity> baseGetRepository, IMapper mapper)
    {
        _baseGetRepository = baseGetRepository;
        _mapper = mapper;
    }

    public async Task<List<TModel>> GetAllAsync()
    {
        return _mapper.Map<List<TModel>>(await _baseGetRepository.GetAll());
    }

    public async Task<TModel> GetByIdAsync(int id)
    {
        return _mapper.Map<TModel>(await _baseGetRepository.GetById(id));
    }
}