namespace Learnify.Shared.DTOs.Course;

public class CourseForUpdateDto
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public long TeacherId { get; set; }
    public long CategoryId { get; set; }
}
