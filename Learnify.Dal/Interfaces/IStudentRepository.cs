using Learnify.Domain.Entities;

namespace Learnify.DAL.Interfaces;

public interface IStudentRepository
{
    Task<IEnumerable<Student>> GetAllAsync();
    Task<Student?> GetByIdAsync(long id);
    Task AddAsync(Student student);
    void Update(Student student);
    Task SaveChangesAsync();
}