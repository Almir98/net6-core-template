namespace Template.Service.Interfaces
{
    public interface IBaseCRUDRepository<Tkey, TEntity> : IBaseGetRepository<Tkey, TEntity> where TEntity : class
    {
        Task<TEntity> Create(TEntity model);
        Task<TEntity> Update(Tkey id, TEntity model);
        void Delete(Tkey id);
    }
}
