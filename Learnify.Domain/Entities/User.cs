using Learnify.Domain.Common;

namespace Learnify.Domain.Entities;

public class User : BaseEntity
{
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Teacher? Teacher { get; set; }
    public Student? Student { get; set; }
}
