using CleanArchitecture.Application.DTO;

namespace CleanArchitecture.Application.Interfaces;

public interface IEmployeeManager
{
    Task<IReadOnlyList<EmployeeModel>> GetEmployee();

    Task<EmployeeModel> AddEmployee(EmployeeModel employee);
}