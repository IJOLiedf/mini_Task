using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Task.Models
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext(DbContextOptions<EmpDbContext> options)
        : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeSkills> EmployeesSkills { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
