namespace Template.Application.Logic.Services
{
    public class BaseGetService<Tkey, TModel> : IBaseGetService<Tkey, TModel> where TModel : class
    {
        protected readonly IBaseGetRepository<Tkey, TModel> _baseGetRepository;
        protected  readonly  IMapper _mapper;

        public BaseGetService(IBaseGetRepository<Tkey, TModel> baseGetRepository, IMapper mapper)
        {
            _baseGetRepository = baseGetRepository;
            _mapper = mapper;
        }

        public async Task<List<TModel>> GetAllAsync()
        {
            return await _baseGetRepository.GetAll();
        }

        public async Task<TModel> GetByIdAsync(Tkey id)
        {
            return await _baseGetRepository.GetById(id);
        }
    }
}
