using Microsoft.AspNetCore.Mvc;
using Core3;

namespace BlazorApp1_nyAPI.Controllers
{
    [ApiController]
    [Route("getweather")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private static readonly string[] Cities = new[]
        {
            "Montreal", "Hammersmith", "New Orleans", "Philadelphia", "Houston", "Salt Lake City"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 20).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)],
                City = Cities[Random.Shared.Next(Cities.Length)]
            })
            .ToArray();
        }
    }
}
