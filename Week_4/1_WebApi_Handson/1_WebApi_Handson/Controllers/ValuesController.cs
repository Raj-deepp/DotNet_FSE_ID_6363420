using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _1_WebApi_Handson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static List<string> values = new() { "value1", "value2" };

        [HttpGet]
        public IActionResult Get() => Ok(values);

        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            values.Add(value);
            return Ok($"Added: {value}");
        }
    }
}

