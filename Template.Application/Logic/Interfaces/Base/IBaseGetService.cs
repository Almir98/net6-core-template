namespace Template.Application.Logic.Interfaces
{
    public interface IBaseGetService<Tkey, TModel> where TModel : class
    {
        Task<List<TModel>> GetAllAsync();
        Task<TModel> GetByIdAsync(Tkey id);
    }
}
