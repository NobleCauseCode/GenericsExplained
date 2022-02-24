using ApiOfThings.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace ApiOfThings.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThingsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var numberList = new ArrayList();
            numberList.Add(10);
            numberList.Add("Savij");
            numberList.Add(new { LastName = "Bar"});

            var onlyNumbersList = new List<int>();
            onlyNumbersList.Add(10);
            onlyNumbersList.Add(20);
            onlyNumbersList.Add(30);
            
            var statesList = new Dictionary<int, string>();
            statesList.Add(20, "North Carolina");
            var selectedState = statesList[20];
            return Ok(onlyNumbersList);
        }

        [HttpGet]
        [Route("api/GetMethod")]
        public IActionResult GetMethod()
        {
            // simulating some other api call
            var result = new ReturnResult<string>
            {
                ErrorMessage = string.Empty,
                Data = "Savij Coder!!!!!!!!"
            };

            return Ok(result);

        }

        [HttpGet]
        [Route("api/GetMethodInt")]
        public IActionResult GetMethodInt()
        {
            // simulating some other api call
            // var people = GetPeople(); // List<Person>();
            var result = new ReturnResult<int>
            {
                ErrorMessage = string.Empty,
                Data = 100
            };

            var otherResult = new ReturnResult<List<Person>>
            {
                ErrorMessage = string.Empty,
                Data = new List<Person> { new Person { Id = 1, Name = "Savij" } }
            };

            var ctorResult = new ReturnResult<int>(101);

            var ctorResultObj = new ReturnResult<List<Person>>(new List<Person> { new Person { Id = 1, Name = "Savij" } });

            return Ok(result);

        }
    }
}
