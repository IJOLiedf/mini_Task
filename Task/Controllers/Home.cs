using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task.Models;

namespace Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Home : ControllerBase
    {
        private readonly EmpDbContext _context;
        public Home(EmpDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult getEmployee()
        {
           
            var employees = from employee in _context.Employees
                            join dept in _context.Department
                            on employee.DepartmentId equals dept.Id
                            select new
                            {
                                employee.Id,
                                employee.Name,
                                employee.Age,
                                employee.Salary,
                                dept.DeptName,  
                            };
            return Ok(employees);
        }
        [HttpPost]
        public IActionResult postEmployee(Employee obj)
        {
            _context.Employees.Add(obj);
            _context.SaveChanges();
            return Ok("Data Inserted");
        }
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, Employee updatedEmployee)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
            {
                return NotFound();
            }

            employee.Name = updatedEmployee.Name;
            employee.Age = updatedEmployee.Age;
            employee.Salary = updatedEmployee.Salary;

            _context.Entry(employee).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.Id == id);

            if (employee == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(employee);
            _context.SaveChanges();

            return NoContent();
        }
    }
}