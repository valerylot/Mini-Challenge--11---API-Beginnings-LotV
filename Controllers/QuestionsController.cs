using Microsoft.AspNetCore.Mvc;

namespace Mini_Challenge__11___API_Beginnings_LotV.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class QuestionsController : ControllerBase
    {
        [HttpGet] //api/questions
        [Route("whatisyourname/{name}/wakeuptime/{time}")]
        public object UserInfo(string name, string time)
        {
            bool success = int.TryParse(time, out int timeWakeUp);
            if (success)
            {
                return $"{name} woke up at {timeWakeUp}";
            }
            else
            {
                return "Please enter a valid number.";
            }
        }
    }
}