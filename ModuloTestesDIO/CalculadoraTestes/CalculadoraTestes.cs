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

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        //Arrange
        int num1 = 10;
        int num2 = 10;
        
        //Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(20, resultado);
    }

    [Fact]
    public void DeveSubtrair300de1233ERetornar933()
    {
        // Given
        int num1 = 1233;
        int num2 = 300;
        // When
        int resultado = _calc.Subtrair(num1,num2);
        // Then
        Assert.Equal(933, resultado);
    }
}