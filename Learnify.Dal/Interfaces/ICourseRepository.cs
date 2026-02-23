using Learnify.Domain.Entities;

namespace Learnify.DAL.Interfaces;

public interface ICourseRepository
{
    Task<IEnumerable<Course>> GetAllAsync();
    Task<Course?> GetByIdAsync(long id);
    Task AddAsync(Course course);
    void Update(Course course);
    Task SaveChangesAsync();
}
