using Learnify.Domain.Entities;

namespace Learnify.DAL.Interfaces;

public interface ITeacherRepository
{
    IQueryable<Teacher> GetAllWithUser();
}
