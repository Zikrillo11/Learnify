using Microsoft.EntityFrameworkCore;
using Learnify.DAL.Data;
using Learnify.DAL.Interfaces;
using Learnify.Domain.Entities;

namespace Learnify.DAL.Repositories;

public class PaymentRepository(AppDbContext context)
    : Repository<Payment>(context), IPaymentRepository
{
    public IQueryable<Payment> GetFullInfo()
        => _dbSet
            .Include(p => p.Student)
                .ThenInclude(s => s.User)
            .Include(p => p.Course)
            .OrderByDescending(p => p.CreatedAt)
            .AsNoTracking();
}
