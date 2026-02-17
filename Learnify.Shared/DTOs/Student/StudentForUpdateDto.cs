namespace Learnify.Shared.DTOs.Student;

public class StudentForUpdateDto
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string Phone { get; set; }
    public string? Email { get; set; }
    public DateTime DateOfBirth { get; set; }
}
