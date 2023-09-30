using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace aspdotnetApiTesting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // GET api/<CalculatorController>/5
        [HttpGet("{firstNumber}, {secondNumber}, {operation}")]
        public string Get(double firstNumber, double secondNumber, string operation)
        {
            double result = 0;

            switch (operation)
            {
                case "plus":
                    result = firstNumber + secondNumber;
                    break;
                case "minus":
                    result = firstNumber - secondNumber;
                    break;
                case "multiply":
                    result = firstNumber * secondNumber;
                    break;
                case "divide":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    result = -1;
                    break;
            }
            return result.ToString();
        }
    }
}
