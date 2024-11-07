using EasyManage.Models;
using EasyManage.Repositories.Interfaces;
using EasyManage.Services.Interfaces;

namespace EasyManage.Services;

public class EmployeeService : IEmployeeService
{
        private readonly IEmployeeRepository _employeeRepository;
        
        public EmployeeService(IEmployeeRepository employeeRepository) 
            => _employeeRepository = employeeRepository;
    
        public void AddEmployee(Employee employee)
            => _employeeRepository.AddEmployee(employee);
    
        public List<Employee> GetAllEmployees()
            => _employeeRepository.GetAllEmployees();
        
        public Employee GetEmployeeById(string cpf)
            => _employeeRepository.GetEmployeeById(cpf);
        
        public void EmployeeUpdate(Employee employeeUpdate)
            => _employeeRepository.EmployeeUpdate(employeeUpdate);

        public void DemissEmployee(string cpf)
            => _employeeRepository.DeleteEmployee(cpf);
    

        public void DeleteEmployeeById(string cpf)
            => _employeeRepository.DeleteEmployee(cpf);
}