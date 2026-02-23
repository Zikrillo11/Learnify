using Learnify.Domain.Entities;

namespace Learnify.DAL.Interfaces;

public interface IPaymentRepository
{
    Task<IEnumerable<Payment>> GetAllAsync();
    Task<Payment?> GetByIdAsync(long id);
    Task AddAsync(Payment payment);
    void Update(Payment payment);
    Task SaveChangesAsync();
}
