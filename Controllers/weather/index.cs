using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System.Threading.Tasks;

public class WeatherFunction
{
    public async Task HandleRequest(HttpContext context)
    {
        var forecast = new List<object>
        {
            new { Date = "2025-01-30", TemperatureC = 22, Summary = "Sunny" },
            new { Date = "2025-01-31", TemperatureC = 18, Summary = "Cloudy" }
        };

        context.Response.ContentType = "application/json";
        await context.Response.WriteAsJsonAsync(forecast);
    }
}
