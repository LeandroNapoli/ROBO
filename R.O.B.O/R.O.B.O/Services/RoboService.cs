using R.O.B.O.Core.Domains;
using R.O.B.O.Services.IServices;
using R.O.B.O.Core.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using System.Linq;

namespace R.O.B.O.Services
{
    public class RoboService : IRoboService
    {
        private IRoboApiService _roboApiService;

        public RoboService()
        {
            _roboApiService = new RoboApiService();
        }
        public async Task AtualizarEstadosDosMembros(MembrosRobo membroViews) => await _roboApiService.AtualizarMembros(membroViews);

        public async Task<IEnumerable<MembroViewModel>> ObterMembros() 
        {
            var membrosAtualizados = JsonConvert.DeserializeObject<IEnumerable<MembroViewModel>>(HttpContext.Current.Session["MembrosRobo"].ToString());
            
            if (!membrosAtualizados.Any())
            {
                return await _roboApiService.ObterMembros();
            }

            return membrosAtualizados;
        }
    }
}