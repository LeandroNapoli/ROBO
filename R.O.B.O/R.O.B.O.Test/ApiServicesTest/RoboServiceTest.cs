using R.O.B.O.Api.Services;
using R.O.B.O.Api.Services.IServices;
using R.O.B.O.Core.Domains;
using R.O.B.O.Core.ViewModels;

namespace R.O.B.O.Test.ApiServicesTest
{
    public class RoboServiceTest
    {
        private IRoboService _roboService;

        public RoboServiceTest()
        {
            _roboService = new RoboService();
        }

        [Fact]
        public void ObterMembrosViewModel()
        {
            //Arrange
            var membros = new MembrosRobo() { Bracos = new HashSet<Braco>(), Cabeca = new Cabeca()};

            //Act
            var resultado = _roboService.ObterMembrosViewModel(membros);

            //Assert
            Assert.IsAssignableFrom<IEnumerable<MembroViewModel>>(resultado);
        }
    }
}
