using Microsoft.AspNetCore.Mvc;

namespace Mini_Challenge__11___API_Beginnings_LotV.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionsController : ControllerBase
    {
        [HttpGet] //api/questions
        [Route("whatisyourname/{name}/wakeuptime/{time}")]
        public ActionResult UserInfo(string name, string time)
        {
            bool success = int.TryParse(time, out int timeWakeUp);
            if (success)
            {
                return Ok($"{name} woke up at {timeWakeUp}");
            }
            else
            {
                return NotFound("Please enter a valid number.");
            }
        }
    }
}