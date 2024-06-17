using R.O.B.O.Core.Domains;
using R.O.B.O.Core.Enums;

namespace R.O.B.O.Test.MembrosTest
{
    public class PulsoTest
    {
        [Fact]
        public void VerificarSePulsoComCoteveloEmRepousoPodeRotacionarEm45Graus()
        {
            //Arrange
            var braco = new Braco();

            //Act / Assert
            Assert.ThrowsAny<Exception>(() => braco.Pulso.VerificarRotacaoPulso(braco.Cotovelo.Estado, Membros.CotoveloDireito));
        }

        [Fact]
        public void VerificarSePulsoComCoteveloLevementeContraidoPodeRotacionarEm45Graus()
        {
            //Arrange
            var braco = new Braco() { Cotovelo = new Cotovelo() { Estado = (int)EstadoCotovelo.LevementeContraido} };

            //Act / Assert
            Assert.ThrowsAny<Exception>(() => braco.Pulso.VerificarRotacaoPulso(braco.Cotovelo.Estado, Membros.CotoveloDireito));
        }

        [Fact]
        public void RotacionarPulsoComCotoveloFortementeContraidoEm45Graus()
        {
            //Arrange
            var braco = new Braco() { Cotovelo = new Cotovelo() { Estado = (int)EstadoCotovelo.FortementeContraido } };

            //Act
            braco.Pulso.VerificarRotacaoPulso(braco.Cotovelo.Estado, Membros.CotoveloDireito);
            braco.Pulso.VerificarRotacao((int)Rotacao.Rotacao45);
            braco.Pulso.Rotacionar((int)Rotacao.Rotacao45);

            // Assert
            Assert.Equal((int)Rotacao.Rotacao45, braco.Pulso.Rotacao);
        }
    }
}
