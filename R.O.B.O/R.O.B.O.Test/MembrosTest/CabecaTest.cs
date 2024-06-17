using R.O.B.O.Core.Domains;
using R.O.B.O.Core.Enums;

namespace R.O.B.O.Test.MembrosTest
{
    public class CabecaTest
    {
        [Fact]
        public void VerificarSeACabecaEmRepousoPodeInclinarEm45Graus()
        {
            //Arrange
            var cabeca = new Cabeca();

            //Act
            var retorno = cabeca.VerificarRotacaoCabeca((int)RotacaoCabeca.Rotacao45);

            //Assert
            Assert.True(retorno);
        }

        [Fact]
        public void VerificarSeACabecaEmRepousoPodeInclinarEm45GrausNegativos()
        {
            //Arrange
            var cabeca = new Cabeca();

            //Act
            var retorno = cabeca.VerificarRotacaoCabeca((int)RotacaoCabeca.Rotacao45Negativo);

            //Assert
            Assert.True(retorno);
        }

        [Fact]
        public void VerificarSeCabecaEmRepousoPodeInclinarEm90Graus()
        {
            //Arange
            var cabeca = new Cabeca();

            //Act / Assert
            Assert.ThrowsAny<Exception>(() => cabeca.VerificarRotacaoCabeca((int)RotacaoCabeca.Rotacao90));

        }

        [Fact]
        public void NaoPermitirRotacaoDaCabecaDevidoAInclinacaoParaBaixo()
        {
            //Arrange
            var cabeca = new Cabeca() { Estado = (int)Inclinacao.ParaBaixo };

            //Act/ Assert
            Assert.ThrowsAny<Exception>(() => cabeca.VerificarRotacaoCabeca((int)RotacaoCabeca.Rotacao45));
        }
    }
}