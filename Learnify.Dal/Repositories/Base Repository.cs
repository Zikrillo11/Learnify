using Microsoft.EntityFrameworkCore;
using Learnify.DAL.Data;

namespace Learnify.DAL.Repositories;

public class Repository<T>(AppDbContext context) where T : class
{
    protected readonly AppDbContext _context = context;
    protected readonly DbSet<T> _dbSet = context.Set<T>();

    public IQueryable<T> GetAll()
        => _dbSet.AsNoTracking();

    public async Task<T?> GetByIdAsync(long id)
        => await _dbSet.FindAsync(id);

    public async Task AddAsync(T entity)
        => await _dbSet.AddAsync(entity);

    public void Update(T entity)
        => _dbSet.Update(entity);

    public void Delete(T entity)
        => _dbSet.Remove(entity);

    public async Task SaveChangesAsync()
        => await _context.SaveChangesAsync();
}
