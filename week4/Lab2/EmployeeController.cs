using Microsoft.AspNetCore.Mvc;
using Lab2_EmployeeAPI.Models;

namespace Lab2_EmployeeAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]  
    public class EmployeeController : ControllerBase
    {
    
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Department = "HR" },
            new Employee { Id = 2, Name = "Bob", Department = "IT" }
        };

        // GET: api/employee
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Employee>> GetAll()
        {
            return Ok(employees);
        }

        // GET: api/employee/1
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Employee> GetById(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp == null)
                return NotFound();
            return Ok(emp);
        }

       
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<Employee> Add(Employee emp)
        {
            employees.Add(emp);
            return CreatedAtAction(nameof(GetById), new { id = emp.Id }, emp);
        }

       
        [HttpPut("{id}")]
        public IActionResult Update(int id, Employee updatedEmp)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp == null) return NotFound();

            emp.Name = updatedEmp.Name;
            emp.Department = updatedEmp.Department;
            return NoContent();
        }

        /
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var emp = employees.FirstOrDefault(e => e.Id == id);
            if (emp == null) return NotFound();

            employees.Remove(emp);
            return NoContent();
        }
    }
}
