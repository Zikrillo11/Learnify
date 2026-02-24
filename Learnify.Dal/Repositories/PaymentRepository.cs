using Learnify.DAL.Data;
using Learnify.Domain.Entities;
using Learnify.Domain.Interfaces.Payments;
using Learnify.Infrastructure.Repositories.Common;
using Microsoft.EntityFrameworkCore;

public class PaymentRepository
    : Repository<Payment>, IPaymentRepository
{
    public PaymentRepository(AppDbContext context)
        : base(context)
    {
    }

    public async Task<IEnumerable<Payment>> GetByStudentIdAsync(long studentId)
    {
        return await _dbSet
            .Where(p => p.StudentId == studentId)
            .ToListAsync();
    }
}