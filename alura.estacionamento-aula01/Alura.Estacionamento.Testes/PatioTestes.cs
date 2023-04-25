using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using Xunit;

namespace Alura.Estacionamento.Testes
{
  public class PatioTestes
  {
    [Fact]
    public void ValidaFaturamento()
    {
      // Arrange
      var estacionamento = new Patio();
      var veiculo = new Veiculo();

      veiculo.Proprietario = "Thomas";
      veiculo.Tipo = TipoVeiculo.Automovel;
      veiculo.Cor = "Verde";
      veiculo.Modelo = "Fusca";
      veiculo.Placa = "asd-9999";

      estacionamento.RegistrarEntradaVeiculo(veiculo);
      estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

      // Act
      double faturamento = estacionamento.TotalFaturado();

      // Assert
      Assert.Equal(2, faturamento);
    }

    /*
        Permite que o teste seja feito com vários tipos de entrada de valor
        não deixando o teste "viciado", fazendo a validação de mais cenários

        Espero que em todos os casos abaixo o resultado seja o mesmo, mesmo passando valores
        diferentes
    */
    [Theory] // permite trabalhar com um conjunto maior de dados
    [InlineData("André Silva", "ASD-1498", "preto", "Gol")]
    [InlineData("Jose Silva", "POL-9242", "Cinza", "Fusca")]
    [InlineData("Maria Silva", "GDR-6524", "Azul", "Opala")]
    [InlineData("Pedro Silva", "GDR-0101", "Azul", "Corsa")]
    public void ValidaFaturamentoComVariosVeiculos(
        string proprietario,
        string placa,
        string cor,
        string modelo
    )
    {
      // Arrange
      Patio estacionamento = new Patio();
      var veiculo = new Veiculo();
      veiculo.Proprietario = proprietario;
      veiculo.Placa = placa;
      veiculo.Cor = cor;
      veiculo.Modelo = modelo;

      estacionamento.RegistrarEntradaVeiculo(veiculo);
      estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);
      // Act
      double faturamento = estacionamento.TotalFaturado();
      // Assert
      Assert.Equal(2, faturamento);
    }
  }
}