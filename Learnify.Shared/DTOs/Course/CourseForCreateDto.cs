namespace Learnify.Shared.DTOs.Course;

public class CourseForCreateDto
{
    public string Name { get; set; }
    public long Id { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public long TeacherId { get; set; }
}
