using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using JwtAuthDemo.Models;

namespace JwtAuthDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin,POC")]  
    public class EmployeesController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Salary = 60000, Department = "HR" },
            new Employee { Id = 2, Name = "Bob", Salary = 70000, Department = "IT" }
        };

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(employees);
        }
    }
}
