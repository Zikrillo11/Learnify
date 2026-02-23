using Learnify.Shared.DTOs.Payment;

namespace Learnify.BLL.Interfaces;

public interface IPaymentService
{
    Task<IEnumerable<PaymentForShortResultDto>> GetAllAsync();
    Task<PaymentForResultDto?> GetByIdAsync(long id);
    Task<PaymentForResultDto> CreateAsync(PaymentForCreateDto dto);
}