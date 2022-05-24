﻿using CleanArchitecture.Application.DTO;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Logger;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : Controller
{
    private readonly IEmployeeManager _employeeManager;
    private readonly ILoggerManager _logger;

    public EmployeeController(IEmployeeManager employeeManager, ILoggerManager logger)
    {
        _employeeManager = employeeManager;
        _logger = logger;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Get()
    {
        throw new Exception();
        var result = await _employeeManager.GetEmployee();
        return new OkObjectResult(result);
    }

    [HttpGet("id")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<EmployeeModel> GetbyId(int id)
    {
        return await _employeeManager.GetEmployeebyId(id);
    }

    [HttpGet("lastName")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IEnumerable<EmployeeModel>> GetbyLastName(string lastName)
    {
        return await _employeeManager.GetEmployeebyLastName(lastName);
    }


    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<EmployeeModel> AddEmployee(EmployeeModel employee)
    {
        return await _employeeManager.AddEmployee(employee);
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task UpdateEmployee(EmployeeModel employee)
    {
        await _employeeManager.UpdateEmployee(employee);
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task DeleteEmployee(EmployeeModel employee)
    {
        await _employeeManager.DeleteEmployee(employee);
    }


}