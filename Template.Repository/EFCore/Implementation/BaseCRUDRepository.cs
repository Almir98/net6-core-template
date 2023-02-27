namespace Template.Domain.EFCore
{
    public class BaseCRUDRepository<Tkey, TEntity, TContext> : BaseGetRepository<Tkey, TEntity, TContext>, IBaseCRUDRepository<Tkey, TEntity> where TEntity : class where TContext : DbContext
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

        public async Task Delete(Tkey id)
        {
            if (id is null)
                throw new ArgumentException(nameof(id));

            var entity = await _context.Set<TEntity>().FindAsync(id);

            if (entity is not null)
            {
                _context.Set<TEntity>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
