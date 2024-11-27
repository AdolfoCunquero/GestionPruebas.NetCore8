using WebApi.Services;

namespace WebApi.Tests.TestProducts;

public class TestProducts
{
    [Fact]
    public void Sumar()
    {
        var service = new CalculadoraService();
        var resultado = service.Sumar(1, 1);
        Assert.Equal(4, resultado);
    }
}