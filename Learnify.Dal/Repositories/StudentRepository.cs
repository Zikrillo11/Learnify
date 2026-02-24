using Learnify.DAL.Data;
using Learnify.Domain.Entities;
using Learnify.Domain.Interfaces.Students;
using Learnify.Infrastructure.Repositories.Common;
namespace Learnify.Infrastructure.Repositories;

public class StudentRepository
    : Repository<Student>, IStudentRepository
{
    public StudentRepository(AppDbContext context)
        : base(context)
    {
    }
}