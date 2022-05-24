using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Repositories;
using CleanArchitecture.Infrastructure.Data;
using CleanArchitecture.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure.Repositories;

public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
{
    private readonly EmployeeContext _context;

    public EmployeeRepository(EmployeeContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Employee>> GetEmployeeByLastName(string lastname)
    {
        return await _context.Employees.Where(m => m.LastName == lastname).ToListAsync();
    }

    public async Task<IEnumerable<Employee>> GetAllEmployeeWithDepartment()
    {
        return await _context.Employees.Include(m=>m.departments).ToListAsync();
    }
}