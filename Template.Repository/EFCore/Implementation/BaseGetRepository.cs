namespace Template.Domain.EFCore;

public class BaseGetRepository<TEntity> : IBaseGetRepository<TEntity> where TEntity : class
{
    public TemplateDbContext _context;

    public BaseGetRepository(TemplateDbContext context)
    {
        _context = context;
    }

    public async Task<List<TEntity>> GetAll()
    {
        return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
    }

    public async Task<TEntity> GetById(int id)
    {
        var entity = await _context.Set<TEntity>().FindAsync(id);

        if (entity is null)
            throw new ArgumentNullException(nameof(entity));

        return entity;
    }
}