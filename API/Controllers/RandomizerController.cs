using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class RandomizerController : ControllerBase
{
    private readonly IRandomizerService _randomizerService;

    public RandomizerController(IRandomizerService randomizerService)
    {
        _randomizerService = randomizerService;
    }

    [HttpGet(Name = "GetRandomNumber")]
    public IActionResult Get()
    {
        try
        {
            var result = new ResponseModel
            {
                Data = new Data
                {
                    Number = _randomizerService.Randomize()
                }
            };

            return Ok(result);
        }
        catch (Exception exception)
        {
            return StatusCode(500, exception.Message);
        }
    }
}