using Microsoft.AspNetCore.Mvc;

namespace Mini_Challenge__11___API_Beginnings_LotV.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InequalityController : ControllerBase
    {
        [HttpGet("{num1}/{num2}")]
        public ActionResult GreaterThanLessThan(string num1, string num2)
        {
            bool success = int.TryParse(num1, out int actualNum1);
            bool success2 = int.TryParse(num2, out int actualNum2);
            if (success == false || success2 == false)
            {
                return NotFound("Please enter a valid number.");
            }
            else
            {
                if (actualNum1 > actualNum2)
                {
                    return Ok($"{actualNum1} is greater than {actualNum2}. {actualNum2} is less than {actualNum1}.");

                }
                else if (actualNum1 < actualNum2)
                {
                    return Ok($"{actualNum1} is less than {actualNum2}. {actualNum2} is greater than {actualNum1}.");
                }
                else
                {
                    return Ok($"{actualNum1} is equal to {actualNum2}");
                }
            }

        }
    }
}
