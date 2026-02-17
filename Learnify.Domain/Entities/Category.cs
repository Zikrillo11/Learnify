using Learnify.Domain.Common;

public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public ICollection<Course> Courses { get; set; } = new List<Course>();
}
