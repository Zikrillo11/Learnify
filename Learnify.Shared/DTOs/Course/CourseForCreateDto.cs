namespace Learnify.Shared.DTOs.Course;

public class CourseForCreateDto
{
    public string Name { get; set; } = string.Empty;
    public long TeacherId { get; set; }
    public long CategoryId { get; set; }
}
