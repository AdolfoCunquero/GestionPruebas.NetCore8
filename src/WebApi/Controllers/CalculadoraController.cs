using Microsoft.AspNetCore.Mvc;
using WebApi.Services;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculadoraController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly ICalculadoraService  _calculadoraService;

    public CalculadoraController(ILogger<WeatherForecastController> logger, ICalculadoraService  calculadoraService)
    {
        _logger = logger;
        _calculadoraService = calculadoraService;
    }

    [HttpGet("sumar")]
    public IActionResult Sumar(int a, int b)
    {
        var resultado = _calculadoraService.Sumar(a, b);
        return Ok(new { Resultado = resultado });
    }
}
