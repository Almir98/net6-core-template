using Microsoft.EntityFrameworkCore;
using Template.Service.Interfaces;
using Template.Service.Services;

namespace Template.Repository.EFCore.Implementation
{
    public class BaseCRUDRepository<Tkey, TEntity, TContext> : BaseGetRepository<Tkey, TEntity, TContext>, IBaseCRUDRepository<Tkey, TEntity, TContext> where TEntity : class where TContext : DbContext
    {
        public BaseCRUDRepository(TContext context) : base(context)
        {
        }

        public async Task<TEntity> Create(TEntity model)
        {
            if (model is null)
                throw new ArgumentNullException(nameof(model));

            _context.Set<TEntity>().Add(model);
            await _context.SaveChangesAsync();

            return model;
        }

        public async Task<TEntity> Update(Tkey id, TEntity model)
        {
            if (id is null)
                throw new ArgumentException(nameof(model));

            _context.Set<TEntity>().Attach(model);
            _context.Set<TEntity>().Update(model);
            await _context.SaveChangesAsync();

            return model;
        }

        public void Delete(Tkey id)
        {
            if (id is null)
                throw new ArgumentException(nameof(id));

            var entity = _context.Set<TEntity>().Find(id);

            if (entity is not null)
            {
                _context.Set<TEntity>().Remove(entity);
                _context.SaveChangesAsync();
            }
        }
    }
}
