using EasyManageWeb.Models;

namespace EasyManageWeb.Repositories;

public interface IEmployeeRepository
{

    public void Add(Employee employee);
    public void Update(Employee employee);
    public void Delete(Employee employee);
    public List<Employee> GetAll();
    public Employee GetById(string cpf);
    
}