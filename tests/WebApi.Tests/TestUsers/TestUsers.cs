using WebApi.Services;

namespace WebApi.Tests.TestUsers;

public class TestUsers
{
    [Fact]
    public void Sumar()
    {
        var service = new CalculadoraService();
        var resultado = service.Sumar(3, 2);
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void Sumar2()
    {
        var service = new CalculadoraService();
        var resultado = service.Sumar(100, 10);
        Assert.Equal(110, resultado);
    }
}