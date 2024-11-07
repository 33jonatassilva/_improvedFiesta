using EasyManage.Models;

namespace EasyManage.Services.Interfaces;

public interface IEmployeeService
{
    void AddEmployee(Employee employee);
    List<Employee> GetAllEmployees();
    Employee GetEmployeeById(string id);
    void EmployeeUpdate(Employee employeeUpdate);
    void DeleteEmployeeById(string cpf);
}