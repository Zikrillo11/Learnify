namespace Learnify.Shared.DTOs.Course;

public class CourseForCreateDto
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int DurationMonths { get; set; }
    public string Description { get; set; }
    public long TeacherId { get; set; }
}
