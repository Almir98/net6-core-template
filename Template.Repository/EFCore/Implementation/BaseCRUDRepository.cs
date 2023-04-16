namespace Template.Domain.EFCore;

public class BaseCRUDRepository<TModel, TEntity> : BaseGetRepository<TModel, TEntity>, IBaseCRUDRepository<TModel> where TEntity : class where TModel : class
{
    public BaseCRUDRepository(TemplateDbContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<TModel> Create(TModel model)
    {
        if (model is null)
            throw new ArgumentNullException(nameof(model));

        _context.Set<TEntity>().Add(_mapper.Map<TEntity>(model));
        await _context.SaveChangesAsync();

        return model;
    }

    public async Task<TModel> Update(int id, TModel model)
    {
        if (id == 0)
            throw new ArgumentException(nameof(model));

        var entity = await _context.Set<TEntity>().FindAsync(id);

        if (entity is null)
            throw new ArgumentException(nameof(model));

        _context.Set<TEntity>().Attach(entity);
        _context.Set<TEntity>().Update(entity);
        _mapper.Map(model, entity);

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