namespace Template.Application.Logic.Services;

public class BaseGetService<TModel> : IBaseGetService<TModel> where TModel : class
{
    protected readonly IBaseGetRepository<TModel> _baseGetRepository;

    public BaseGetService(IBaseGetRepository<TModel> baseGetRepository)
    {
        _baseGetRepository = baseGetRepository;
    }

    public async Task<List<TModel>> GetAllAsync()
    {
        return await _baseGetRepository.GetAll();
    }

    public async Task<TModel> GetByIdAsync(int id)
    {
        return await _baseGetRepository.GetById(id);
    }
}