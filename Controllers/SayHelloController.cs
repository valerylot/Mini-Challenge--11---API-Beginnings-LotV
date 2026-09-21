using Microsoft.AspNetCore.Mvc;

namespace Mini_Challenge__11___API_Beginnings_LotV.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SayHelloController : ControllerBase
    {

        [HttpGet] //api/sayhello
        public string SayHello()
        {
            return "Hello";
        }
        
        [HttpGet]
        [Route("{name}")]
        public string Username(string name)
        {
            return $"Hello {name}";
        }
    }
}