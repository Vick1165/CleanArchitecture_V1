using CleanArchitecture.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Data;

public class EmployeeContext : DbContext
{
    public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
    {
    }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Departments> Departments { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var i = 0;
        // Seed database with all Colors
        foreach (var s in "HR,IT,Accounts".Split(","))
        {
            Departments colorDto = new Departments
            {
                Id = ++i,
                Department = s,
            };

            modelBuilder.Entity<Departments>().HasData(colorDto);
        }
    }
}