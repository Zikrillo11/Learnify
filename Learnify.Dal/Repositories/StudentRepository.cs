using Microsoft.EntityFrameworkCore;
using Learnify.DAL.Data;
using Learnify.DAL.Interfaces;
using Learnify.Domain.Entities;

namespace Learnify.DAL.Repositories;

public class StudentRepository(AppDbContext context)
    : Repository<Student>(context), IStudentRepository
{
    public IQueryable<Student> GetAllWithUser()
        => _dbSet
            .Include(s => s.User)
            .OrderByDescending(s => s.CreatedAt)
            .AsNoTracking();
}
