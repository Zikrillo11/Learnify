using Learnify.Domain.Entities;

namespace Learnify.DAL.Interfaces;

public interface ITeacherRepository
{
    Task<IEnumerable<Teacher>> GetAllAsync();
    Task<Teacher?> GetByIdAsync(long id);
    Task AddAsync(Teacher teacher);
    void Update(Teacher teacher);
    Task SaveChangesAsync();
}
