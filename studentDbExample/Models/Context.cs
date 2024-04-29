using Microsoft.EntityFrameworkCore;

namespace studentDbExample.Models
{
    public class Context:DbContext
    {
        public Context( DbContextOptions<Context> options):base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
