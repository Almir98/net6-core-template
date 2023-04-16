namespace Template.Service.Interfaces
{
    public interface IBaseCRUDRepository<TEntity> : IBaseGetRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Create(TEntity model);
        Task<TEntity> Update(int id, TEntity model);
        Task Delete(int id);
    }
}
