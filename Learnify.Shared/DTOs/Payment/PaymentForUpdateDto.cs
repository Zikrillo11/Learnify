namespace Learnify.Shared.DTOs.Payment;

public class PaymentForUpdateDto
{
    public long Id { get; set; }
    public long StudentId { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaidAt { get; set; }
    public string Method { get; set; }
}
