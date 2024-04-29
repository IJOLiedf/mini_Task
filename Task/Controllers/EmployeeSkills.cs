using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task.Models;

namespace Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeSkills : ControllerBase
    {
        private readonly EmpDbContext _context;
        public EmployeeSkills(EmpDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
            
            var employeeSkills = from employee in _context.Employees
                            join skill in _context.EmployeesSkills
                            on employee.Id equals skill.EmployeeId
                            select new
                            {
                                skill.Id,
                                skill.Skill,
                                skill.EmployeeId,
                                employee.Name,

                            };
            return Ok(employeeSkills);
        }
        [HttpPost]
        public IActionResult Post( Task.Models.EmployeeSkills obj)
        {
            _context.EmployeesSkills.Add(obj);
            _context.SaveChanges();
            return Ok("Data Inserted");
        }
    }
}
