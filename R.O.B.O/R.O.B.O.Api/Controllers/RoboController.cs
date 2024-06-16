using R.O.B.O.Core.Domains;
using R.O.B.O.Api.Services;
using R.O.B.O.Api.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using R.O.B.O.Core.ViewModels;

namespace R.O.B.O.Api.Controllers
{
    [Route("robo")]
    public class RoboController : ControllerBase
    {
        private IRoboService _roboService;

        public RoboController()
        {
            _roboService = new RoboService();
        }

        [HttpGet]
        [Route("obter-membros")]
        public IEnumerable<MembroViewModel> ObterMembros()
        {
            try
            {
                return _roboService.ObterMembros();
            }
            catch
            {
                return Enumerable.Empty<MembroViewModel>();
            }
        }

        [HttpPut]
        [Route("atualizar-membros")]
        public bool AtualizarMembros(MembrosRobo membro)
        {
            try
            {
                _roboService.AtualizarMembros(membro);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
