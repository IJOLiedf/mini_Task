using System.ComponentModel.DataAnnotations.Schema;

namespace EmpDbContext.Models
{
    [Table("Department")]
    public class Department
    {
        public string DeptName {  get; set; }
        public Employee Employee { get; set; }
    }
}
