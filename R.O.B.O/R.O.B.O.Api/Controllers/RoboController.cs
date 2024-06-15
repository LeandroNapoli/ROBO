using Microsoft.AspNetCore.Mvc;
using R.O.B.O.Core.Domains;
using R.O.B.O.Api.Services;
using R.O.B.O.Api.Services.IServices;
using System.Text.Json;

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
        public HttpResponseMessage ObterMembros()
        {
            try
            {
                var membros = _roboService.ObterMembros();
                var content = new StringContent(JsonSerializer.Serialize(membros));
                return new HttpResponseMessage() { Content = content, StatusCode = System.Net.HttpStatusCode.OK };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage() { Content = new StringContent(JsonSerializer.Serialize(ex)), StatusCode = System.Net.HttpStatusCode.InternalServerError };
            }
        }

        [HttpPut]
        [Route("atualizar-membros")]
        public HttpResponseMessage AtualizarMembros(MembrosRobo membro)
        {
            try
            {
                _roboService.AtualizarMembros(membro);
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage() { Content = new StringContent(JsonSerializer.Serialize(ex)), StatusCode = System.Net.HttpStatusCode.InternalServerError };
            }
        }
    }
}
