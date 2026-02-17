using Learnify.Domain.Entities;

namespace Learnify.DAL.Interfaces;

public interface IStudentRepository
{
    IQueryable<Student> GetAllWithUser();
}
