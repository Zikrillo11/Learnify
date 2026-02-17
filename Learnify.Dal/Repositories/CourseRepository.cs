using Microsoft.EntityFrameworkCore;
using Learnify.DAL.Data;
using Learnify.DAL.Interfaces;
using Learnify.Domain.Entities;

namespace Learnify.DAL.Repositories;

public class CourseRepository(AppDbContext context)
    : Repository<Course>(context), ICourseRepository
{
    public IQueryable<Course> GetFullInfo()
        => _dbSet
            .Include(c => c.Category)
            .Include(c => c.Teacher)
                .ThenInclude(t => t.User)
            .OrderByDescending(c => c.CreatedAt)
            .AsNoTracking();
}
