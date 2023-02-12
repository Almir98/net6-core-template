using Microsoft.EntityFrameworkCore;
using Template.Service.Interfaces;

namespace Template.Service.Services
{
    public class BaseGetRepository<TKey, TModel, TContext> : IBaseGetRepository<TKey, TModel> where TContext : DbContext where TModel : class
    {
        protected readonly TContext _context;

        public BaseGetRepository(TContext context)
        {
            _context = context;
        }

        public async Task<List<TModel>> GetAll()
        {
            return await _context.Set<TModel>().AsNoTracking().ToListAsync();
        }

        public async Task<TModel> GetById(TKey id)
        {
            var entity = await _context.Set<TModel>().FindAsync(id);

            if (entity is null)
                return null;

            return entity;
        }
    }
}
