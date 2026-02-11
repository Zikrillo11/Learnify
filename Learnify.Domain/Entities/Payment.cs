using Learnify.Domain.Common;

namespace Learnify.Domain.Entities;

public class Payment : BaseEntity
{
    public long StudentId { get; set; }
    public Student Student { get; set; } = null;
    public decimal Amount { get; set; }
    public DateTime PaidAt { get; set; } = DateTime.UtcNow;
    public string Method { get; set; }
}
