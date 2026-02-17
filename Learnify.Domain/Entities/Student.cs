using Learnify.Domain.Common;

namespace Learnify.Domain.Entities;

public class Student : BaseEntity
{
    public long UserId { get; set; }
    public User User { get; set; } = null!;

    public ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
