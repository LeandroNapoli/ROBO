using R.O.B.O.Core.Domains;
using R.O.B.O.Core.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace R.O.B.O.Services.IServices
{
    public interface IRoboApiService
    {
        Task AtualizarMembros(MembrosRobo membro);
        Task<IEnumerable<MembroViewModel>> ObterMembros();
    }
}
