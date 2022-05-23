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
        var employeeList = await _employeeRepository.GetAllAsync();
        var result = _mapper.Map<IReadOnlyList<EmployeeModel>>(employeeList);
        return result;
    }

    public async Task<EmployeeModel> AddEmployee(EmployeeModel employeeModel)
    {
        var employee = _mapper.Map<Employee>(employeeModel);
        var result = await _employeeRepository.AddAsync(employee);
        var mappedResult = _mapper.Map<EmployeeModel>(result);
        return mappedResult;
    }
}