using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Repositories.Base;

namespace CleanArchitecture.Core.Repositories;

public interface IEmployeeRepository : IRepository<Employee>
{
    Task<IEnumerable<Employee>> GetEmployeeByLastName(string lastname);
}