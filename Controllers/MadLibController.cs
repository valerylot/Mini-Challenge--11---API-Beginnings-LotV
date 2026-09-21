using Microsoft.AspNetCore.Mvc;

namespace Mini_Challenge__11___API_Beginnings_LotV.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MadLibController : ControllerBase
    {
        [HttpGet("{animal}/{adjective1}/{adjective2}/{adjective3}/{noun1}/{noun2}/{adjective4}/{food}/{place}/{adjective5}")]
        public ActionResult MadLib1(string animal, string adjective1, string adjective2, string adjective3, string noun1, string noun2, string adjective4, string food, string place, string adjective5)
        {
           return Ok($"If you've ever met my {animal}, Snoopy, then you know he's not your average canine companion. Some kids might find it {adjective1} that their beagle has such a/an {adjective2} imagination, but not me! All I'ev ever wanted was a normal, {adjective3} dog. Why can't I have a/an {noun1} just like everyone else? Instead, I've got a part-time pet, part-time World War I pilot, part-time {noun2}, and a full-time pain! {adjective4} grief! Sometimes he looks at me like I'm chopped {food} - good for nothing except bringing his dinner out to the {place}. Still, it sure is nice to have someone with really {adjective5} ears around."); 
        }
    }
}
