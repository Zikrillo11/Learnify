namespace Learnify.Shared.DTOs.Payment;

public class PaymentForCreateDto
{
    public decimal Amount { get; set; }
    public long StudentId { get; set; }
    public long CourseId { get; set; }
}
