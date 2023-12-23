using Calculadora.Services;
using Xunit.Sdk;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private CalculadoraImplementacao _calc;
    public CalculadoraTestes()
    {
        _calc = new CalculadoraImplementacao();
    }
    [Fact] //fact  é o que diz que o metodo abaixo é um teste
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;
        
        //Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(15, resultado);
    }
}