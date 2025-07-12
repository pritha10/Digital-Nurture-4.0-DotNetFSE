using Microsoft.AspNetCore.Mvc;
using YourNamespace.Models;

namespace YourNamespace.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Alice",
                    Salary = 50000,
                    Permanent = true,
                    Department = new Department { Id = 101, Name = "HR" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "Communication" },
                        new Skill { Id = 2, Name = "Management" }
                    },
                    DateOfBirth = new DateTime(1990, 5, 1)
                }
            };
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(GetStandardEmployeeList());
        }

        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee emp)
        {
            return CreatedAtAction(nameof(Get), new { id = emp.Id }, emp);
        }
    }
}
