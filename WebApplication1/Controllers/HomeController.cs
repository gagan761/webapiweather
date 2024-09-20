using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    [Route("crud")]
    public class HomeController : ControllerBase
    {
        public HomeController()
        {
           
        }

        [HttpGet("weather")]
        public ActionResult<IEnumerable<List<WeatherModel>>> GetAllWeather()
        {
            List<WeatherModel> WeatherData = new List<WeatherModel>
        {
            new WeatherModel
            {
                CityName = "Delhi",
                Forecast = new List<Condition>
                {
                    new Condition { Day = "Monday", Temp = "283.88", Humidity = "76" },
                    new Condition { Day = "Tuesday", Temp = "284.88", Humidity = "77" },
                    new Condition { Day = "Wednesday", Temp = "285.88", Humidity = "78" },
                    new Condition { Day = "Thrusday", Temp = "286.88", Humidity = "79" },
                    new Condition { Day = "Friday", Temp = "287.88", Humidity = "80" },
                    new Condition { Day = "Saturday", Temp = "288.88", Humidity = "81" },
                    new Condition { Day = "Sunday", Temp = "289.88", Humidity = "82" }
                }
            },
            new WeatherModel
            {
                CityName = "Mumbai",
                Forecast = new List<Condition>
                {
                   new Condition { Day = "Monday", Temp = "283.88", Humidity = "2" },
                    new Condition { Day = "Tuesday", Temp = "284.88", Humidity = "3" },
                    new Condition { Day = "Wednesday", Temp = "285.88", Humidity = "4" },
                    new Condition { Day = "Thrusday", Temp = "286.88", Humidity = "5" },
                    new Condition { Day = "Friday", Temp = "287.88", Humidity = "6" },
                    new Condition { Day = "Saturday", Temp = "288.88", Humidity = "7" },
                    new Condition { Day = "Sunday", Temp = "289.88", Humidity = "8" }
                }
            }
            // Combine all the data into a single list

        };

            new UserRepository();
            Console.WriteLine(WeatherData);
            return Ok(WeatherData);
            
            }
    }
}
