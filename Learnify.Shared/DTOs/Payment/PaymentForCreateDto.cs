namespace Learnify.Shared.DTOs.Payment;

public class PaymentForCreateDto
{
    public long StudentId { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaidAt { get; set; }
    public string Method { get; set; }
}
