using Learnify.Domain.Entities;

namespace Learnify.DAL.Interfaces;

public interface ICourseRepository
{
    IQueryable<Course> GetFullInfo();
}
