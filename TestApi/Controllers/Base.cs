using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Base : ControllerBase
    {
        [HttpGet("user")] 
        public string Print()
        {
            return "Okkk";
        }
    }
}