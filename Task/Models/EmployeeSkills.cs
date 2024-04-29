using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task.Models
{
    [Table("EmployeeSkills")]
    public class EmployeeSkills
    {
        [Key]
        public int Id { get; set; }
        public string Skill { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
    }
}
