namespace Template.Service.Interfaces
{
    public interface IBaseGetRepository<TKey, TModel> where TModel : class
    {
        Task<List<TModel>> GetAll();
        Task<TModel> GetById(TKey id);
    }
}
