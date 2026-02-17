using Learnify.Domain.Common;

namespace Learnify.Domain.Entities;

public class Payment : BaseEntity
{
    public decimal Amount { get; set; }

    public long StudentId { get; set; }
    public Student Student { get; set; } = null!;

    public long CourseId { get; set; }
    public Course Course { get; set; } = null!;
}
