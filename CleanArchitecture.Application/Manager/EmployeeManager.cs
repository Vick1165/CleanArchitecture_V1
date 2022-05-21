using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Repositories;

namespace CleanArchitecture.Application.Manager;

public class EmployeeManager : IEmployeeManager
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeManager(IEmployeeRepository  employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<IReadOnlyList<Employee>> GetEmployee()
    {
        return await _employeeRepository.GetAllAsync();
    }

    public async Task<Employee> AddEmployee( Employee employee)
    {
        return await _employeeRepository.AddAsync(employee);
    }
}
