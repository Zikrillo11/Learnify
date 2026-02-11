using Learnify.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Learnify.DAL.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Payment> Payments { get; set; }

}