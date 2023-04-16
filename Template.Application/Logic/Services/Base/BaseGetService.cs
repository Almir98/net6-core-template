namespace Template.Application.Logic.Services;

public class BaseGetService<TModel> : IBaseGetService<TModel> where TModel : class
{
    protected readonly IBaseGetRepository<TModel> _baseGetRepository;
    //protected  readonly  IMapper _mapper;

    public BaseGetService(IBaseGetRepository<TModel> baseGetRepository /*,IMapper mapper */)
    {
        _baseGetRepository = baseGetRepository;
        //_mapper = mapper;
    }

    public async Task<List<TModel>> GetAllAsync()
    {
        return await _baseGetRepository.GetAll();

        //return _mapper.Map<List<TModel>>(await _baseGetRepository.GetAll());
    }

    public async Task<TModel> GetByIdAsync(int id)
    {
        return await _baseGetRepository.GetById(id);

        //return _mapper.Map<TModel>(await _baseGetRepository.GetById(id));
    }
}