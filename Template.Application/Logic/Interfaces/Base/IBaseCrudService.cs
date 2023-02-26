namespace Template.Application.Logic.Interfaces
{
    public interface IBaseCrudService<Tkey, TModel, TEntity> : IBaseGetService<Tkey, TModel> where TModel : class where TEntity : class
    {
        Task<TEntity> Create(TModel model);

        Task<TEntity> Update(Tkey id, TModel model);
        
        void Delete(Tkey id);
    }
}
