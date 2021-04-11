
using BethanysPieShopHRM.Api.Models;
using BethanysPieShopHRM.Shared;

using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShopHRM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository) => _employeeRepository = employeeRepository;

        [HttpGet]
        public IActionResult GetAllEmployees() => Ok(_employeeRepository.GetAllEmployees());

        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id) => Ok(_employeeRepository.GetEmployeeById(id));

        [HttpPost]
        public IActionResult CreateEmployee([FromBody] EmployeeModel employee)
        {
            if (employee is null)
            {
                return BadRequest();
            }

            if (employee.FirstName == string.Empty || employee.LastName == string.Empty)
            {
                ModelState.AddModelError("Name/FirstName", "The first or last name shouldn't be empty");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var employeeToUpdate = _employeeRepository.GetEmployeeById(employee.EmployeeId);

            if (employeeToUpdate is null)
            {
                return NotFound();
            }

            _employeeRepository.UpdateEmployee(employee);

            return NoContent(); // success
        }

        [HttpDelete("id")]
        public IActionResult DeleteEmployee(int id)
        {
            if (id is 0)
            {
                return BadRequest();
            }

            var employeeToDelete = _employeeRepository.GetEmployeeById(id);
            if (employeeToDelete is null)
            {
                return NotFound();
            }

            _employeeRepository.DeleteEmployee(id);

            return NoContent(); // success
        }
    }
}