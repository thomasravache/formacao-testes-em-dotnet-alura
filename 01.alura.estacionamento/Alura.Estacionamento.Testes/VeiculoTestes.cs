using System;
using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using Xunit;

namespace Alura.Estacionamento.Testes
{
    public class VeiculoTestes
    {
        // Adicionar displayname para o nome do teste aparecer com um "apelido"
        [Fact(DisplayName = "Teste Numero 1")]
        [Trait("Funcionalidade", "Acelerar")] //
        public void TestaVeiculoAcelerar()
        {
            // Arrange
            var veiculo = new Veiculo();

            // Act
            veiculo.Acelerar(10);

            // Assert
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }

        [Fact(DisplayName = "Teste Numero 2")]
        [Trait("Funcionalidade", "Acelerar")] // adicionar configuracoes que deixem a visualizacao mais agradavel e ajuda na performance de testes
        public void TestaVeiculoFrear()
        {
            // Arrange
            var veiculo = new Veiculo();

            // Act
            veiculo.Frear(10);

            // Assert
            Assert.Equal(-150, veiculo.VelocidadeAtual);
        }

        [Fact]
        public void TestaVeiculoTipo()
        {
            // Arrange
            var veiculo = new Veiculo();

            // Act

            // Assert
            Assert.Equal(TipoVeiculo.Automovel, veiculo.Tipo);
        }

        // utilizar o parametro skip para pular testes por algum determinado motivo
        [Fact(DisplayName = "Teste Numero 3", Skip="Teste ainda não implementado")]
        public void ValidaNomeProprietario()
        {
            
        }
    }
}
