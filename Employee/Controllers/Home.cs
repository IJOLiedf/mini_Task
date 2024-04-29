using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmpDbContext.Models;

namespace Employee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Home : ControllerBase
    {
        private readonly EmpDbContext.Models.EmpDbContext _context;
        public Home(EmpDbContext.Models.EmpDbContext context)
        {
            _context = context;
        }
    }
}
