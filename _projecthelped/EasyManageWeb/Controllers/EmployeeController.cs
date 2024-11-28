using EasyManageWeb.Models;
using EasyManageWeb.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EasyManageWeb.Controllers;

[ApiController]
[Route("employees")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeController(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    [HttpPost("add")]
    public IActionResult Add([FromBody] Employee employee)
    {
        _employeeRepository.Add(employee);
        return Ok(new { message = "Employee added successfully" });
    }

    [HttpPut("update")]
    public IActionResult Update([FromBody] Employee employee)
    {
        var existingEmployee = _employeeRepository.GetById(employee.Cpf);
        if (existingEmployee == null)
        {
            return NotFound(new { message = "Employee not found" });
        }

        _employeeRepository.Update(employee);
        return Ok(new { message = "Employee updated successfully" });
    }

    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var employees = _employeeRepository.GetAll();
        if (employees == null || !employees.Any())
        {
            return NotFound(new { message = "No employees found" });
        }

        return Ok(employees);
    }

    [HttpGet("{cpf}")]
    public IActionResult GetById([FromRoute] string cpf)
    {
        var employee = _employeeRepository.GetById(cpf);
        if (employee == null)
        {
            return NotFound(new { message = "Employee not found" });
        }

        return Ok(employee);
    }
}