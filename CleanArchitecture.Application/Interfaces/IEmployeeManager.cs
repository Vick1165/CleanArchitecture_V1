using CleanArchitecture.Application.DTO;

namespace CleanArchitecture.Application.Interfaces;

public interface IEmployeeManager
{
    Task<IReadOnlyList<EmployeeResponseModel>> GetEmployee();

    Task<EmployeeResponseModel> AddEmployee(EmployeeRequestModel employee);
    Task UpdateEmployee(EmployeeRequestModel employeeModel);
    Task<EmployeeRequestModel> GetEmployeebyId(int id);
    Task DeleteEmployee(EmployeeRequestModel employeeModel);
    Task<IEnumerable<EmployeeRequestModel>> GetEmployeebyLastName(string lastname);
}