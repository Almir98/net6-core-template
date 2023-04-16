using AutoMapper;

namespace Template.Domain.EFCore;

public class BaseGetRepository<TModel, TEntity> : IBaseGetRepository<TModel> where TModel : class where TEntity : class
{
    protected readonly TemplateDbContext _context;
    protected readonly IMapper _mapper;


    public BaseGetRepository(TemplateDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<TModel>> GetAll()
    {
        var response = await _context.Set<TEntity>().AsNoTracking().ToListAsync();

        return _mapper.Map<List<TModel>>(response);
    }

    public async Task<TModel> GetById(int id)
    {
        var entity = await _context.Set<TEntity>().FindAsync(id);

        if (entity is null)
            throw new ArgumentNullException(nameof(entity));

        return _mapper.Map<TModel>(entity);

        //return entity;

        return null;
    }
}