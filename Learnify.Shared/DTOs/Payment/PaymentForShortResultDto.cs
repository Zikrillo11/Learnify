namespace Learnify.Shared.DTOs.Payment;

public class PaymentForShortResultDto
{
    public long Id { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaidAt { get; set; }
}
