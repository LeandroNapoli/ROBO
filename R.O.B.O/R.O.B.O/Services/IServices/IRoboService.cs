using R.O.B.O.Core.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using R.O.B.O.Core.Domains;

namespace R.O.B.O.Services.IServices
{
    public interface IRoboService
    {
        Task<IEnumerable<MembroViewModel>> ObterMembros();
        Task AtualizarEstadosDosMembros(MembrosRobo membroViews);
    }
}
