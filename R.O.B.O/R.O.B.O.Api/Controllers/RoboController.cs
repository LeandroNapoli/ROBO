using R.O.B.O.Core.Domains;
using R.O.B.O.Api.Services;
using R.O.B.O.Api.Services.IServices;
using System.Web.Http;

namespace R.O.B.O.Api.Controllers
{
    [Route("robo")]
    public class RoboController : ApiController
    {
        private IRoboService _roboService;

        public RoboController()
        {
            _roboService = new RoboService();
        }

        [HttpGet]
        [Route("obter-membros")]
        public IHttpActionResult ObterMembros()
        {
            try
            {
                var membros = _roboService.ObterMembros();
                return Ok(membros);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("atualizar-membros")]
        public IHttpActionResult AtualizarMembros(MembrosRobo membro)
        {
            try
            {
                _roboService.AtualizarMembros(membro);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
