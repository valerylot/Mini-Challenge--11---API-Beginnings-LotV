using Microsoft.AspNetCore.Mvc;

namespace Mini_Challenge__11___API_Beginnings_LotV.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddNumbersController : ControllerBase
    {
        [HttpGet]
        [Route("{usernum1}/{usernum2}")] //api/AddNumbers/num1/num2
        public object AddNumbers(string userNum1, string userNum2)
        {
            bool success = int.TryParse(userNum1, out int num1);
            bool success2 = int.TryParse(userNum2, out int num2);
            int sum = num1 + num2;
            if (success && success2)
            {
                return sum;   
            }
            else
            {
                return "Invalid input. Please enter numbers.";
            }
        }
    }
}