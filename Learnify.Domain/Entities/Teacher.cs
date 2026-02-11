using Learnify.Domain.Common;

namespace Learnify.Domain.Entities;

public class Teacher : BaseEntity
{
    public string FullName { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string Specialty { get; set; } = null!;
}
