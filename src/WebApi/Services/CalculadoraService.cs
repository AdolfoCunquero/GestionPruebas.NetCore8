namespace WebApi.Services;

public interface ICalculadoraService
{
    int Sumar(int a, int b);
}

public class CalculadoraService : ICalculadoraService
{
    public int Sumar(int a, int b) => a + b;
}