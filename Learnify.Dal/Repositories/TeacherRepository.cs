using Microsoft.EntityFrameworkCore;
using Learnify.DAL.Data;
using Learnify.DAL.Interfaces;
using Learnify.Domain.Entities;

namespace Learnify.DAL.Repositories;

public class TeacherRepository(AppDbContext context)
    : Repository<Teacher>(context), ITeacherRepository
{
    public IQueryable<Teacher> GetAllWithUser()
        => _dbSet
            .Include(t => t.User)
            .Include(t => t.Courses)
            .OrderByDescending(t => t.CreatedAt)
            .AsNoTracking();
}
