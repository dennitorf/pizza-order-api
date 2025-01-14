using Microsoft.AspNetCore.Mvc;

namespace Restaurant.Pizza.WebApi.Controllers
{
    [Route("ns-ms-name/api/[controller]")]
    [ApiController]
    public class Health : ControllerBase
    {
        [HttpGet("GetHealthCheck")]
        public string Get()
        {
            return "i'm healthy";
        }

        public StatusCodeResult DefaultResponse()
        {
            return StatusCode(505);
        }
        
    }
}