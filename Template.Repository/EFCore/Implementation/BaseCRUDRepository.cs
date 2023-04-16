namespace Template.Domain.EFCore;

public class BaseCRUDRepository<TEntity> : BaseGetRepository<TEntity>, IBaseCRUDRepository<TEntity> where TEntity : class
{
    public BaseCRUDRepository(TemplateDbContext context) : base(context)
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

    public async Task<TEntity> Update(int id, TEntity model)
    {
        if (id == 0)
            throw new ArgumentException(nameof(model));

        _context.Set<TEntity>().Attach(model);
        _context.Set<TEntity>().Update(model);
        await _context.SaveChangesAsync();

        return model;
    }

    public async Task Delete(int id)
    {
        if (id == 0)
            throw new ArgumentException(nameof(id));

        var entity = await _context.Set<TEntity>().FindAsync(id);

        if (entity is not null)
        {
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}