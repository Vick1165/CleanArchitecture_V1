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
        // Seed database with all Department Type
        foreach (DepartmentType departmentType in Enum.GetValues(typeof(DepartmentType)).Cast<DepartmentType>())
        {
            Departments departments = new Departments
            {
                Id = ++i,
                Department = departmentType.ToString(),
            };

            modelBuilder.Entity<Departments>().HasData(departments);
        }
    }
}