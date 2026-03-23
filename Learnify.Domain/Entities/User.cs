using Learnify.Domain.Common;

namespace Learnify.Domain.Entities;

public class User : BaseEntity
{
    public long Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Role { get; set; } = "Student"; // "Admin", "Teacher", "Student"
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
