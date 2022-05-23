using CleanArchitecture.Application.DTO;
using CleanArchitecture.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : Controller
{
    private readonly IEmployeeManager _employeeManager;

    public EmployeeController(IEmployeeManager employeeManager)
    {
        _employeeManager = employeeManager;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IReadOnlyList<EmployeeModel>> Get()
    {
        return await _employeeManager.GetEmployee();
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<EmployeeModel> AddEmployee(EmployeeModel employee)
    {
        return await _employeeManager.AddEmployee(employee);
    }
}