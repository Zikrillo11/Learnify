namespace Learnify.Shared.DTOs.Course;

public class CourseForResultDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int DurationMonths { get; set; }
    public string Description { get; set; }
    public long TeacherId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
