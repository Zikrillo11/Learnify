using Learnify.Domain.Common;

namespace Learnify.Domain.Entities;
public class Student : BaseEntity
{
    public string FirstName { get; set; } = null;
    public string Phone { get; set; } = null;
    public string? Email { get; set; }
    public DateTime DateOfBirth { get; set; }
}
