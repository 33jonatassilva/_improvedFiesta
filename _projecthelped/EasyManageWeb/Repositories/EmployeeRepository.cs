using EasyManageWeb.Context;
using EasyManageWeb.Models;
using EasyManageWeb.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EasyManageWeb.Repositories;

public class EmployeeRepository : IEmployeeRepository
{

    private readonly AppDbContext _context;

    public EmployeeRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public void Add(Employee employee)
    {
        _context.Employees.Add(employee);
        _context.SaveChanges();
    }

    public void Update(Employee employee)
    {
        _context.Employees.Update(employee);
        _context.SaveChanges();
    }

    public void Delete(Employee employee)
    {
        _context.Employees.Remove(employee);
        _context.SaveChanges();
    }

    public List<Employee> GetAll()
    {
        var employees = _context.Employees.ToList();
        return employees;
    }
    

    public Employee GetById(string cpf)
    {
        var employee = _context.Employees.FirstOrDefault(x => x.Cpf == cpf);
        return employee;
    }
}