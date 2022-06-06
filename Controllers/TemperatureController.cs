using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TemperatureAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class TemperatureController : ControllerBase
  {
    private readonly ILogger<TemperatureController> _logger;

    public TemperatureController(ILogger<TemperatureController> logger)
    {
      _logger = logger;
    }

    [HttpGet("{city}")]
    public ActionResult<Temperature> Get(string city)
    {
      Console.WriteLine("City name %s= ", city);
      var temperature = new Temperature()
      {
        Text = "🌻"
      };

      return Ok(temperature);
    }
  }
}
