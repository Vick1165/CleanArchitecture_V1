using CleanArchitecture.Application.DTO;

namespace CleanArchitecture.Application.Interfaces;

public interface IEmployeeManager
{
    Task<IReadOnlyList<EmployeeModel>> GetEmployee();

    Task<EmployeeModel> AddEmployee(EmployeeModel employee);
    Task UpdateEmployee(EmployeeModel employeeModel);
    Task<EmployeeModel> GetEmployeebyId(int id);
    Task DeleteEmployee(EmployeeModel employeeModel);
    Task<IEnumerable<EmployeeModel>> GetEmployeebyLastName(string lastname);
}