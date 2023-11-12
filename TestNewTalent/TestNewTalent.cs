using System.ComponentModel;
using NewTalent.Services;

namespace TestNewTalent;

public class TestNewTalent
{

    private CalculadoraDesen _calcDesen;

    public TestNewTalent(){
        _calcDesen = new CalculadoraDesen("02/02/2023");

        
    }

    
     [Theory]
    [InlineData(10, 5, 15)]
    [InlineData(10, 10, 20)]
    public void DeveSomar10Com5ERetornar(  int n1,  int n2, int resu )
    {
     
    // act

    int resultado = _calcDesen.Somar(n1,n2);

    //Assert

    Assert.Equal(resu,resultado);

    }


    
    [Fact]
    public void DeveSubtrair10Com7ERetornar()
    {


    // arrange

        int n1 = 10;

        int n2 = 7;


    // act

    int resultado = _calcDesen.Subtrair(n1,n2);

    //Assert

    Assert.Equal(3,resultado);

    }


    
    [Theory]
    [InlineData(7, 5, 35)]
    [InlineData(10, 10, 100
    )]
    public void DeveMultiplicar10Com10ERetornar(int n1, int n2, int Resu)
    {


    // act

    int resultado = _calcDesen.Multiplicar(n1,n2);

    //Assert

    Assert.Equal(Resu, resultado);

    }


    [Fact]
    public void DeveDivir12Com4ERetornar()
    {


    // arrange

        int n1 = 12;

        int n2 = 4;


    // act

    int resultado = _calcDesen.Dividir(n1,n2);


    //Assert

    Assert.Equal(3, resultado);

    var excecao = Assert.Throws<ArgumentException>(() => _calcDesen.Dividir(3, 0));
    Assert.Equal("Nao pode ser dividido por ZERO, meu caro amigo", excecao.Message);
    }


     [Fact]
public void DeveRetornarHistorico()
{
    // Act
    var lista = _calcDesen.Historico();

    _calcDesen.Somar(2,2);
    _calcDesen.Somar(4,2);
    _calcDesen.Somar(6,2);
    _calcDesen.Somar(8,2);
    _calcDesen.Somar(3,4);

    // Debug
    Console.WriteLine($"Número de elementos no histórico: {lista.Count}");

    // Assert
    Assert.NotEmpty(lista);
    Assert.Equal(5, lista.Count);
}



    

}