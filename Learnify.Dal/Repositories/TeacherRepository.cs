using Learnify.DAL.Data;
using Learnify.Domain.Entities;
using Learnify.Domain.Interfaces.Teachers;
using Learnify.Infrastructure.Repositories.Common;

public class TeacherRepository
    : Repository<Teacher>, ITeacherRepository
{
    public TeacherRepository(AppDbContext context)
        : base(context)
    {
    }
}