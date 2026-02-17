using Learnify.Domain.Common;

namespace Learnify.Domain.Entities;

public class Teacher : BaseEntity
{
    public long UserId { get; set; }
    public User User { get; set; } = null!;

    public ICollection<Course> Courses { get; set; } = new List<Course>();
}
