using Learnify.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Learnify.DAL.Data;

public class AppDbContext : DbContext
{  
    public AppDbContext(DbContextOptions<AppDbContext> options)  
        : base(options)
    {
    } 
    public DbSet<User> Users => Set<User>();   
    public DbSet<Admin> Admins { get; set; }   
    public DbSet<Student> Students => Set<Student>();
    public DbSet<Teacher> Teachers => Set<Teacher>();
    public DbSet<Course> Courses => Set<Course>();
    public DbSet<Payment> Payments => Set<Payment>();
    public DbSet<Category> Categories => Set<Category>();
}
