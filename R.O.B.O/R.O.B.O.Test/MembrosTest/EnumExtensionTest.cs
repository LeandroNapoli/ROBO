using R.O.B.O.Core.Enums;
using R.O.B.O.Core.Extensions;

namespace R.O.B.O.Test.MembrosTest
{
    public class EnumExtensionTest
    {
        [Fact]
        public void ObterDisplayNameEnumRotacao45Graus()
        {
            //Arrange
            var esperado = "Rotação 45º";

            //Act
            var retorno = Rotacao.Rotacao45.ObterDisplayName();

            //Assert
            Assert.Equal(esperado, retorno);
        }

        [Fact]
        public void ObterNomePulsoDireitoSemEspaco()
        {
            //Arrange
            var esperado = "PulsoDireito";

            //Act
            var retorno = Membros.PulsoDireito.ObterDisplayName();

            //Assert
            Assert.Equal(esperado, retorno);
        }

        [Fact]
        public void FalharAoObterNomePulsoDireitoComEspaco()
        {
            //Arrange
            var esperado = "Pulso Direito";

            //Act
            var retorno = Membros.PulsoDireito.ObterDisplayName();

            //Assert
            Assert.NotEqual(esperado, retorno);
        }
    }
}
