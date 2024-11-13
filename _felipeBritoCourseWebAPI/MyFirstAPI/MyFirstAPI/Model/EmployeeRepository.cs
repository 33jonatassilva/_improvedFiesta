
using MyFirstAPI.Context;

namespace MyFirstAPI.Model
{
    public class EmployeeRepository : IEmployeeRepository
    {

        private readonly AppDbContext _context = new AppDbContext();
        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public List<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }


        public Employee GetEmployee(Guid id)
        {
            return _context.Employees.FirstOrDefault(x => x.Id == id);
        }
    }
}
