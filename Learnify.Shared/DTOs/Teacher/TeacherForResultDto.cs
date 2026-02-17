namespace Learnify.Shared.DTOs.Teacher;

public class TeacherForResultDto
{
    public long Id { get; set; }
    public string FullName { get; set; }
    public string Phone { get; set; }
    public string Specialty { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
