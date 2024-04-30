using Application.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly BlogDbContext _blogDbContext;

        public Repository(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext;
        }
        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _blogDbContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            T? result = await _blogDbContext.Set<T>().FindAsync(id);
            return result;
        }

        public async Task<T> AddAsync(T entity)
        {
            _ = await _blogDbContext.Set<T>().AddAsync(entity);
            _ = await _blogDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _ = _blogDbContext.Set<T>().Remove(entity);
            _ = await _blogDbContext.SaveChangesAsync();
        }


        public async Task UpdateAsync(T entity)
        {
            _blogDbContext.Entry(entity).State = EntityState.Modified;
            _ = await _blogDbContext.SaveChangesAsync();
        }
    }
}
