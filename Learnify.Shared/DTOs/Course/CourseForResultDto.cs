namespace Learnify.Shared.DTOs.Course;

public class CourseForResultDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public long TeacherId { get; set; }
    public long CategoryId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
}
