using R.O.B.O.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using R.O.B.O.Domains;

namespace R.O.B.O.Services.IServices
{
    public interface IRoboService
    {
        Task<IEnumerable<MembroViewModel>> ObterEstadosDosMembros();
        Task AtualizarEstadosDosMembros(IEnumerable<Membro> membroViews);
    }
}
