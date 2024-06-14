using R.O.B.O.Api.Domains.Abstracts;
using R.O.B.O.Api.Services;
using R.O.B.O.Api.Services.IServices;
using System.Web.Http;

namespace R.O.B.O.Api.Controllers
{
    [RoutePrefix("robo")]
    public class RoboController : ApiController
    {
        private IRoboService _roboService;

        public RoboController()
        {
            _roboService = new RoboService();
        }

        [HttpGet]
        [Route("obter-membros")]
        public async Task<IHttpActionResult> ObterMembros()
        {
            try
            {
                var membros = await _roboService.ObterMembros();
                return Ok(membros);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPut]
        [Route("atualizar-membros")]
        public async Task<IHttpActionResult> AtualizarMembros(IEnumerable<Membro> membro)
        {
            try
            {
                await _roboService.AtualizarMembros(membro);
                return Ok();
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
