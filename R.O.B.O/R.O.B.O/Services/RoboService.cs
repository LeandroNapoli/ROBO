using R.O.B.O.Core.Domains;
using R.O.B.O.Services.IServices;
using R.O.B.O.Core.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public async Task<IEnumerable<MembroViewModel>> ObterMembros() => await _roboApiService.ObterMembros();
    }
}