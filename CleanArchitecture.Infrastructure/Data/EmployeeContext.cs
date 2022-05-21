using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Data;

public class EmployeeContext : DbContext
{
    public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }

    public DbSet<Employee> Employees { get; set; }


}
