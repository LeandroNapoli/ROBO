using R.O.B.O.Domains;
using R.O.B.O.Services.IServices;
using R.O.B.O.ViewModels;
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
        public async Task AtualizarEstadosDosMembros(IEnumerable<Membro> membroViews) => await _roboApiService.AtualizarMembros(membroViews);

        public async Task<IEnumerable<MembroViewModel>> ObterEstadosDosMembros() => await _roboApiService.ObterMembros();
    }
}