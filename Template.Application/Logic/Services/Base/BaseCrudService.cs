namespace Template.Application.Logic.Services
{
    public class BaseCrudService<Tkey, TModel, TEntity> : BaseGetService<Tkey, TModel>, IBaseCrudService<Tkey, TModel, TEntity> where TModel : class where TEntity : class
    {
        protected readonly IBaseCRUDRepository<Tkey, TEntity> _baseCrudRepository;        // ?????

        public BaseCrudService(IBaseGetRepository<Tkey, TModel> baseGetRepository, IMapper mapper, IBaseCRUDRepository<Tkey, TEntity> baseCrudRepository) : base(baseGetRepository, mapper)
        {
            _baseCrudRepository = baseCrudRepository;
        }

        public async Task<TEntity> Create(TModel model)
        {
            return await _baseCrudRepository.Create(_mapper.Map<TEntity>(model));
        }

        public async Task<TEntity> Update(Tkey id, TModel model)
        {
            return await _baseCrudRepository.Update(id, _mapper.Map<TEntity>(model));
        }

        public async Task Delete (Tkey id)
        {
           await _baseCrudRepository.Delete(id);
        }
    }
}
