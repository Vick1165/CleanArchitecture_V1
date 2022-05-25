using CleanArchitecture.Application.DTO;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Logger;
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
    public async Task<IActionResult> Get()
    {
        var result = await _employeeManager.GetEmployee();
        return new OkObjectResult(result);
    }

    [HttpGet("id")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<EmployeeRequestModel> GetbyId(int id)
    {
        return await _employeeManager.GetEmployeebyId(id);
    }

    [HttpGet("lastName")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IEnumerable<EmployeeRequestModel>> GetbyLastName(string lastName)
    {
        return await _employeeManager.GetEmployeebyLastName(lastName);
    }


    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> AddEmployee(EmployeeRequestModel employee)
    {
        return new OkObjectResult(await _employeeManager.AddEmployee(employee));
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task UpdateEmployee(EmployeeRequestModel employee)
    {
        await _employeeManager.UpdateEmployee(employee);
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task DeleteEmployee(EmployeeRequestModel employee)
    {
        await _employeeManager.DeleteEmployee(employee);
    }


}