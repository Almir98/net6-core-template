using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Template.Service.Interfaces
{
    public interface IBaseCRUDRepository<Tkey, TEntity, TContext> : IBaseGetRepository<Tkey, TEntity> where TEntity : class where TContext : DbContext
    {
        Task<TEntity> Create(TEntity model);
        Task<TEntity> Update(Tkey id, TEntity model);
        void Delete(Tkey id);
    }
}
