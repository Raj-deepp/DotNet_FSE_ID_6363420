using _5_WebApi_Handson.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _5_WebApi_Handson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "POC,Admin")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> _employees = new()
        {
            new Employee { Id = 1, Name = "Ravi", Department = "HR" },
            new Employee { Id = 2, Name = "Sita", Department = "IT" }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_employees);
        }
    }
}

