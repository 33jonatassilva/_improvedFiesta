using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyFirstAPI.Model;
using MyFirstAPI.ViewModel;

namespace MyFirstAPI.Controllers
{

    [ApiController]
    [Route("api/v1/employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }


        [HttpPost("/post")]
        public IActionResult Add([FromForm] EmployeeViewModel employeeView)
        {

            var filepath = Path.Combine("Storage", employeeView.Photo.FileName);


            using Stream fileStream = new FileStream(filepath, FileMode.Create);
            employeeView.Photo.CopyTo(fileStream);

            var employee = new Employee(employeeView.Name, employeeView.Age, filepath);

            _employeeRepository.Add(employee);

            return Ok();
        }

        [HttpGet("/get")]
        public IActionResult GetAll()
        {
            var employees = _employeeRepository.GetAll();

            return Ok(employees);
        }


        [HttpPost]
        [Route("{id}/download")]
        public IActionResult DownloadPhoto(Guid id)
        {
            var employee = _employeeRepository.GetEmployee(id);

            var dataBytes = System.IO.File.ReadAllBytes(employee.Photo);

            return File(dataBytes, "image/png");
        }
    }
}
