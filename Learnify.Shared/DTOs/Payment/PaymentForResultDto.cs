namespace Learnify.Shared.DTOs.Payment;

public class PaymentForResultDto
{
    public long Id { get; set; }
    public long StudentId { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaidAt { get; set; }
    public string Method { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
