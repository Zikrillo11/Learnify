using Learnify.Domain.Common;

namespace Learnify.Domain.Entities;

public class Teacher : BaseEntity
{
    public string FullName { get; set; }
    public string Phone { get; set; }
    public string Specialty { get; set; }
}
