namespace Template.Service.Interfaces
{
    public interface IBaseGetRepository<TKey, TEntity> where TEntity : class
    {
        Task<List<TEntity>> GetAll();
        Task<TEntity> GetById(TKey id);
    }
}
