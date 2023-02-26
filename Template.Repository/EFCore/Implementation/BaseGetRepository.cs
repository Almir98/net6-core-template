namespace Template.Domain.EFCore
{
    public class BaseGetRepository<TKey, TEntity, TContext> : IBaseGetRepository<TKey, TEntity> where TContext : DbContext where TEntity : class
    {
        protected readonly TContext _context;

        public BaseGetRepository(TContext context)
        {
            _context = context;
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> GetById(TKey id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);

            if (entity is null)
                throw new ArgumentNullException(nameof(entity));

            return entity;
        }
    }
}
