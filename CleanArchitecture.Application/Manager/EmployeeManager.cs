using AutoMapper;
using CleanArchitecture.Application.DTO;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Repositories;

namespace CleanArchitecture.Application.Manager;

public class EmployeeManager : IEmployeeManager
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;

    public EmployeeManager(IEmployeeRepository employeeRepository, IMapper mapper)
    {
        _employeeRepository = employeeRepository;
        _mapper = mapper;
    }

    public async Task<IReadOnlyList<EmployeeModel>> GetEmployee()
    {
        var employeeList = await _employeeRepository.GetAllEmployeeWithDepartment();
        var result = _mapper.Map<IReadOnlyList<EmployeeModel>>(employeeList);
        return result;
    }

    public async Task<EmployeeModel> GetEmployeebyId(int id)
    {
        var employeeList = await _employeeRepository.GetByIdAsync(id);
        var result = _mapper.Map<EmployeeModel>(employeeList);
        return result;
    }

    public async Task<IEnumerable<EmployeeModel>> GetEmployeebyLastName(string lastname)
    {
        var employeeList = await _employeeRepository.GetEmployeeByLastName(lastname);
        var result = _mapper.Map<IEnumerable<EmployeeModel>>(employeeList);
        return result;
    }

    public async Task<EmployeeModel> AddEmployee(EmployeeModel employeeModel)
    {

        var employee = _mapper.Map<Employee>(employeeModel);
        var result = await _employeeRepository.AddAsync(employee);
        var mappedResult = _mapper.Map<EmployeeModel>(result);
        return mappedResult;
    }

    public async Task UpdateEmployee(EmployeeModel employeeModel)
    {
        var employee = _mapper.Map<Employee>(employeeModel);
        await _employeeRepository.UpdateAsync(employee);

    }

    public async Task DeleteEmployee(EmployeeModel employeeModel)
    {
        var employee = _mapper.Map<Employee>(employeeModel);
        await _employeeRepository.DeleteAsync(employee);

    }
}