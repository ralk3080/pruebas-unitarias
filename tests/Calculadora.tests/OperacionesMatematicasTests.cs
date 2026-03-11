using Calculadora;

namespace Calculadora.Tests;

public class OperacionesMatematicasTests
{

    //Arrange
    private readonly OperacionesMatematicas _operacionesMatematicas = new();

    [Fact]
    public void Sumar_DosPositivos_RetornaLaSuma()
    {
      // Arrange
      int a = 5; 
      int b = 3;

      // Act
      var resultado = _operacionesMatematicas.Sumar(a, b);

      // Assert
      Assert.Equal(8, resultado);
    }

    [Fact]
    public void Sumar_NegativoMasPositivo_RetornaValorCorrecto()
    {
      // Arrange
      int a = -5; 
      int b = 3;

      // Act
      var resultado = _operacionesMatematicas.Sumar(a, b);

      // Assert
      Assert.Equal(-2, resultado);
    }

    [Fact]
    public void Sumar_CoreoMasCero_RetornaCero()
    {
      // Arrange
      int a = 0; 
      int b = 0;

      // Act
      var resultado = _operacionesMatematicas.Sumar(a, b);

      // Assert
      Assert.Equal(0, resultado);
    }
    
    [Fact]
public void Resta_DosPositivos_RetornaLaResta()
{
    // Arrange
    int a = 5;
    int b = 3;

    // Act
    var resultado = _operacionesMatematicas.Restar(a, b);

    // Assert
    Assert.Equal(2, resultado);
}

    [Fact]
    public void Resta_NegativoMenosPositivo_RetornaValorCorrecto()
    {
        // Arrange
        int a = -5;
        int b = 3;

        // Act
        var resultado = _operacionesMatematicas.Restar(a, b);

        // Assert
        Assert.Equal(-8, resultado);
    }

    [Fact]
    public void Resta_CeroMenosCero_RetornaCero()
    {
        // Arrange
        int a = 0;
        int b = 0;

        // Act
        var resultado = _operacionesMatematicas.Restar(a, b);

        // Assert
        Assert.Equal(0, resultado);
    }

}
