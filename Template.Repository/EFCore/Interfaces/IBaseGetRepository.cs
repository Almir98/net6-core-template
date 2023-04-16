namespace Template.Service.Interfaces;

public interface IBaseGetRepository<TEntity> where TEntity : class
{
    Task<List<TEntity>> GetAll();
    Task<TEntity> GetById(int id);
}