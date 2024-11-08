using EasyManage.Models;

namespace EasyManage.Services.Interfaces;

public interface IEmployeeService
{
    void AddEmployee(Employee employee);
    List<Employee> GetAllEmployees();
    Employee GetEmployeeById(string id);
    void EmployeeUpdate(Employee employeeUpdate);

    void EmployeeUpdate(string employeeId, Employee employee);
    void DemissEmployee(string cpf);
    void DeleteEmployeeById(string cpf);
}