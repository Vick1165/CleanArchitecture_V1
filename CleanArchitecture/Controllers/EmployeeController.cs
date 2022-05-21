using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Core.Entities;
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
    public async Task<IReadOnlyList<Employee>> Get()
    {
        return await _employeeManager.GetEmployee();
    }
}
