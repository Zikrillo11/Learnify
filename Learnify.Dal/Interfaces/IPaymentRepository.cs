using Learnify.Domain.Entities;
using Learnify.Domain.Interfaces.Common;

namespace Learnify.Domain.Interfaces.Payments;

public interface IPaymentRepository : IRepository<Payment>
{
    Task<IEnumerable<Payment>> GetByStudentIdAsync(long studentId);
}