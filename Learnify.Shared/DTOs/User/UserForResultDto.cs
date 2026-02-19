namespace Learnify.Shared.DTOs.User;

public  class UserForResultDto
{
    public long Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; } 
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
}
