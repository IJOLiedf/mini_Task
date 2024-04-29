using System.ComponentModel.DataAnnotations.Schema;

namespace EmpDbContext.Models
{
    [Table("EmployeeSkills")]
    public class EmployeeSkills
    {
        public Employee Employee { get; set; }
        public string Skill {  get; set; }
    }
}
