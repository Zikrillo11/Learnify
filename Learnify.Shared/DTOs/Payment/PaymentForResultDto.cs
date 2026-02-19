namespace Learnify.Shared.DTOs.Payment;

public class PaymentForResultDto
{
    public long Id { get; set; }
    public decimal Amount { get; set; }
    public long StudentId { get; set; }
    public long CourseId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
}
