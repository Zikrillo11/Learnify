using Learnify.DAL.Data;
using Learnify.Domain.Interfaces.Courses;
using Learnify.Infrastructure.Repositories.Common;

public class CourseRepository
    : Repository<Course>, ICourseRepository
{
    public CourseRepository(AppDbContext context)
        : base(context)
    {
    }
}