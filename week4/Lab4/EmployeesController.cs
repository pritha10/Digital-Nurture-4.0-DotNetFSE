// Controllers/EmployeesController.cs
using Microsoft.AspNetCore.Mvc;
using EmployeeApi.Models;

namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {
        // Simulating database using static hardcoded list
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Salary = 60000, Department = "HR" },
            new Employee { Id = 2, Name = "Bob", Salary = 70000, Department = "IT" },
            new Employee { Id = 3, Name = "Charlie", Salary = 80000, Department = "Finance" }
        };

        // PUT: api/employees/2
        [HttpPut("{id}")]
        public ActionResult<Employee> UpdateEmployee(int id, [FromBody] Employee updatedEmployee)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            var existingEmployee = employees.FirstOrDefault(e => e.Id == id);

            if (existingEmployee == null)
            {
                return BadRequest("Invalid employee id");
            }

            // Update employee details
            existingEmployee.Name = updatedEmployee.Name;
            existingEmployee.Salary = updatedEmployee.Salary;
            existingEmployee.Department = updatedEmployee.Department;

            return Ok(existingEmployee); // Return updated employee
        }
    }
}
