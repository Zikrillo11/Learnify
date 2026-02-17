using Learnify.Domain.Entities;

namespace Learnify.DAL.Interfaces;

public interface IPaymentRepository
{
    IQueryable<Payment> GetFullInfo();
}
