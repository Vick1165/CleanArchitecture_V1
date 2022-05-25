using AutoMapper;
using CleanArchitecture.Application.DTO;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Repositories;
using CleanArchitecture.Core.Repositories.Base;

namespace CleanArchitecture.Application.Manager;

public class EmployeeManager : IEmployeeManager
{
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IMapper _mapper;
    private readonly IRepository<Departments> _repository;

    public EmployeeManager(IEmployeeRepository employeeRepository, IMapper mapper,IRepository<Departments> repository)
    {
        _employeeRepository = employeeRepository;
        _mapper = mapper;
        _repository = repository;
    }

    public async Task<IReadOnlyList<EmployeeResponseModel>> GetEmployee()
    {
        var employeeList = await _employeeRepository.GetAllEmployeeWithDepartment();
        var result = _mapper.Map<IReadOnlyList<EmployeeResponseModel>>(employeeList);
        return result;
    }

    public async Task<EmployeeRequestModel> GetEmployeebyId(int id)
    {
        var employeeList = await _employeeRepository.GetByIdAsync(id);
        var result = _mapper.Map<EmployeeRequestModel>(employeeList);
        return result;
    }

    public async Task<IEnumerable<EmployeeRequestModel>> GetEmployeebyLastName(string lastname)
    {
        var employeeList = await _employeeRepository.GetEmployeeByLastName(lastname);
        var result = _mapper.Map<IEnumerable<EmployeeRequestModel>>(employeeList);
        return result;
    }

    public async Task<EmployeeResponseModel> AddEmployee(EmployeeRequestModel employeeModel)
    {

        var employee = _mapper.Map<Employee>(employeeModel);
        var result = await _employeeRepository.AddAsync(employee);
        result.departments = await _repository.GetByIdAsync(result.DepartmentId);
        var mappedResult = _mapper.Map<EmployeeResponseModel>(result);
        return mappedResult;
    }

    public async Task UpdateEmployee(EmployeeRequestModel employeeModel)
    {
        var employee = _mapper.Map<Employee>(employeeModel);
        await _employeeRepository.UpdateAsync(employee);

    }

    public async Task DeleteEmployee(EmployeeRequestModel employeeModel)
    {
        var employee = _mapper.Map<Employee>(employeeModel);
        await _employeeRepository.DeleteAsync(employee);

    }
}