using Learnify.Domain.Common;

namespace Learnify.Domain.Entities;
public class Student : BaseEntity
{
    public string FirstName { get; set; }
    public string Phone { get; set; }
    public string? Email { get; set; }
    public DateTime DateOfBirth { get; set; }
}
