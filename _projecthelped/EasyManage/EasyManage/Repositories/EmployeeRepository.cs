using EasyManage.Data;
using EasyManage.Models;
using EasyManage.Repositories.Interfaces;

namespace EasyManage.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
            => _context = context;
    

        public void AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }
    
    
        public List<Employee> GetAllEmployees()
        {
            return _context.Employees.ToList();
        }
    
    
        public Employee GetEmployeeById(string cpf)
        {
            var employee =  _context.Employees.FirstOrDefault(x => x.Cpf == cpf);
            _context.Employees.Remove(employee);

            return employee;
        }

        public void EmployeeUpdate(Employee employee)
        {   
            _context.Employees.Update(employee);
            _context.SaveChanges();

            Console.WriteLine(employee.ToString());
        }

        public void Demiss(string cpf)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Cpf == cpf);
            employee.OffboardingDate = DateTime.Now;
            _context.Employees.Update(employee);
            _context.SaveChanges();
        }

        public void DeleteEmployee(string cpf)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Cpf == cpf);
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }
}