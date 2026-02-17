using Learnify.Domain.Common;

namespace Learnify.Domain.Entities;

public class Teacher : BaseEntity
{
    // User bilan bog‘lovchi foreign key
    public long UserId { get; set; }

    // User navigation property — aynan shu kerak
    public User User { get; set; } = null!;

    public ICollection<Course> Courses { get; set; } = new List<Course>();
}
