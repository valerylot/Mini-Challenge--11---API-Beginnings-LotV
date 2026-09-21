using Microsoft.AspNetCore.Mvc;

namespace Mini_Challenge__11___API_Beginnings_LotV.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SayHelloController : ControllerBase
    {

        [HttpGet("{name}")] //api/sayhello
        public ActionResult SayHello(string name)
        {
            return Ok($"Hello {name}");
        }
        
    }
}